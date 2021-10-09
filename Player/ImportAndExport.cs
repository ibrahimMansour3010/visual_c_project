using BLLayer;
using DBLayer;
using System;
using System.Windows.Forms;

namespace Player
{
    public partial class ImportAndExport : Form
    {
        StockServices StockServices;
        CategoryServices CategoryServices;
        ItemServices ItemServices;
        ItemInStockServices ItemInStockServices;

        public ImportAndExport()
        {
            InitializeComponent();
            StockServices = new StockServices();
            CategoryServices = new CategoryServices();
            ItemServices = new ItemServices();
            ItemInStockServices = new ItemInStockServices();
            FillComponents();
        }
        // fill all components for the first time
        void FillComponents()
        {
            // Import
            stockList.DisplayMember = "Name";
            stockList.ValueMember = "ID";
            stockList.DataSource = StockServices.GetStocks();
            catList.DisplayMember = "Name";
            catList.ValueMember = "ID";
            catList.DataSource = CategoryServices.GetAllCategories();
            itemList.DisplayMember = "Name";
            itemList.ValueMember = "ID";
            itemList.DataSource = ItemServices.GetAllItemsByCatID((int?)catList.SelectedValue);
            importsDGV.DataSource = ItemInStockServices.GetAllItemInStock((int?)stockList.SelectedValue, importTab.Text);
            importsDGV.Columns[0].Visible = false;
            importsDGV.Columns[1].Visible = false;

            /// Export
            stockListExported.DisplayMember = "Name";
            stockListExported.ValueMember = "ID";
            stockListExported.DataSource = StockServices.GetStocks();
            fillExport();
            ///// Reoprt
            stockListReport.DisplayMember = "Name";
            stockListReport.ValueMember = "ID";
            stockListReport.DataSource = StockServices.GetStocks();
            FillReport((int?)stockListReport.SelectedValue);
            importDate.Value = DateTime.Now;
            exportDate.Value = DateTime.Now;
        }
        //// Import
        //// change stock
        private void stockList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (stockList.SelectedIndex != -1)
            {
                importsDGV.DataSource = ItemInStockServices.GetAllItemInStock((int?)stockList.SelectedValue, importTab.Text);
            }
        }
        //// change category
        private void catList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (catList.SelectedIndex != -1)
            {
                itemList.DisplayMember = "Name";
                itemList.ValueMember = "ID";
                itemList.DataSource = ItemServices.GetAllItemsByCatID((int?)catList.SelectedValue);
                FillReport((int?)stockListReport.SelectedValue);

            }
            else
            {
                itemList.Items.Clear();
            }
        }
        //// when select in datagridview in import items
        private void importsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (importsDGV.SelectedRows.Count > 0)
            {
                int item_id = (int)importsDGV.SelectedRows[0].Cells[1].Value;
                int cat_id = ItemServices.GetCatID(item_id);
                itemList.SelectedValue = item_id;
                catList.SelectedValue = cat_id;
                decimal res;
                decimal.TryParse(importsDGV.SelectedRows[0].Cells[4].Value.ToString(), out res);
                importQuantity.Value = res;
                importDate.Value = (DateTime)importsDGV.SelectedRows[0].Cells[5].Value;
            }
        }
        // add import
        private void addImportBTN_Click(object sender, EventArgs e)
        {
            if (stockList.SelectedIndex == -1 || itemList.SelectedIndex == -1)
            {
                MessageBox.Show("There Is Not Stock Or Item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ItemInStockServices.AddItemInStock(
              new ItemInStock()
              {
                  Item_ID = (int)itemList.SelectedValue,
                  Stock_ID = (int)stockList.SelectedValue,
                  Quantity = (int)importQuantity.Value,
                  Date = importDate.Value,
                  Status = importTab.Text
              }
              );
                importsDGV.DataSource = ItemInStockServices.GetAllItemInStock((int?)stockList.SelectedValue, importTab.Text);
                fillExport();
                FillReport((int?)stockListReport.SelectedValue);
            }
        }

        //// update import
        private void saveImportBTN_Click(object sender, EventArgs e)
        {
            if (stockList.SelectedIndex == -1 || itemList.SelectedIndex == -1 || importsDGV.SelectedRows.Count == 0 ||
                ItemServices.GetQuantity((int?)importsDGV.SelectedRows[0].Cells[1].Value, (int?)stockList.SelectedValue) <= 0)
            {
                MessageBox.Show("There Is Not Stock, Item Or No Selected Row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int itemInStockID = (int)importsDGV.SelectedRows[0].Cells[0].Value;
                ItemInStockServices.EditItemInStock(itemInStockID, (int)importQuantity.Value, importDate.Value);
                importsDGV.DataSource = ItemInStockServices.GetAllItemInStock((int?)stockList.SelectedValue, importTab.Text);
                fillExport();
                FillReport((int?)stockListReport.SelectedValue);
            }
        }
        // delete import
        private void deleteImportBTN_Click(object sender, EventArgs e)
        {
            if (stockList.SelectedIndex == -1 || itemList.SelectedIndex == -1 || importsDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("There Is Not Stock, Item Or No Selected Row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (ItemServices.GetQuantity((int?)importsDGV.SelectedRows[0].Cells[1].Value, (int?)stockList.SelectedValue) > 0)
                {
                    int itemInStockID = (int)importsDGV.SelectedRows[0].Cells[0].Value;
                    ItemInStockServices.DeleteItemInStock(itemInStockID);
                    importsDGV.DataSource = ItemInStockServices.GetAllItemInStock((int?)stockList.SelectedValue, importTab.Text);
                    fillExport();
                    FillReport((int?)stockListReport.SelectedValue);

                }
                else
                {
                    MessageBox.Show("Cannot Delete Import Quntity That has been Exported", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
        //// export
        /// fill export controls
        private void fillExport()
        {

            catListExported.DisplayMember = "Name";
            catListExported.ValueMember = "ID";
            catListExported.DataSource = CategoryServices.GetAllCatByStockID((int?)stockListExported.SelectedValue, importTab.Text);
            itemListExported.DisplayMember = "Name";
            itemListExported.ValueMember = "ID";
            itemListExported.DataSource = ItemServices.GetAllItemsByCatIDandStockID((int?)catListExported.SelectedValue, (int?)stockListExported.SelectedValue);
            exportsDGV.DataSource = ItemInStockServices.GetAllItemInStock((int?)stockListExported.SelectedValue, tabPage2.Text);
            exportsDGV.Columns[0].Visible = false;
            exportsDGV.Columns[1].Visible = false;
            currQuantity.Value = ItemServices.GetQuantity((int?)itemListExported.SelectedValue, (int?)stockListExported.SelectedValue);

        }
        //// when change stock
        private void stockListExported_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (stockListExported.SelectedIndex != -1)
            {
                exportsDGV.DataSource = ItemInStockServices.GetAllItemInStock((int?)stockListExported.SelectedValue, tabPage2.Text);
                catListExported.DisplayMember = "Name";
                catListExported.ValueMember = "ID";
                catListExported.DataSource = CategoryServices.GetAllCatByStockID((int?)stockListExported.SelectedValue, importTab.Text);
                itemListExported.DisplayMember = "Name";
                itemListExported.ValueMember = "ID";
                itemListExported.DataSource = ItemServices.GetAllItemsByCatIDandStockID((int?)catListExported.SelectedValue, (int?)stockListExported.SelectedValue);
            }
        }
        //// when change category
        private void catListExported_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (catListExported.SelectedIndex != -1)
            {
                itemListExported.DisplayMember = "Name";
                itemListExported.ValueMember = "ID";
                itemListExported.DataSource = ItemServices.GetAllItemsByCatIDandStockID((int?)catListExported.SelectedValue, (int?)stockListExported.SelectedValue);
            }
        }
        //// when change item the quantity apper in numericupdown
        private void itemListExported_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemListExported.SelectedIndex != -1)
            {
                currQuantity.Value = ItemServices.GetQuantity((int?)itemListExported.SelectedValue, (int?)stockListExported.SelectedValue);
            }
        }
        //// when select from datagridview in export items
        private void exportsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (exportsDGV.SelectedRows.Count > 0)
            {
                int item_id = (int)exportsDGV.SelectedRows[0].Cells[1].Value;
                int cat_id = ItemServices.GetCatID(item_id);
                itemListExported.SelectedValue = item_id;
                catListExported.SelectedValue = cat_id;
                decimal res;
                decimal.TryParse(exportsDGV.SelectedRows[0].Cells[4].Value.ToString(), out res);
                exportQuantity.Value = res;
                exportDate.Value = (DateTime)exportsDGV.SelectedRows[0].Cells[5].Value;
            }
        }
        //// add export
        private void addExportBTN_Click(object sender, EventArgs e)
        {

            if ((int)exportQuantity.Value > (int)currQuantity.Value)
            {
                MessageBox.Show("This Quantity Is Not Available Right Now", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (stockListExported.SelectedIndex == -1 || itemListExported.SelectedIndex == -1)
                {
                    MessageBox.Show("There Is Not Stock Or Item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ItemInStockServices.AddItemInStock(
                    new ItemInStock()
                    {
                        Item_ID = (int)itemListExported.SelectedValue,
                        Stock_ID = (int)stockListExported.SelectedValue,
                        Quantity = (int)exportQuantity.Value,
                        Date = exportDate.Value,
                        Status = tabPage2.Text
                    }
                    );
                    exportsDGV.DataSource = ItemInStockServices.GetAllItemInStock((int?)stockListExported.SelectedValue, tabPage2.Text);
                    fillExport();
                    FillReport((int?)stockListReport.SelectedValue);
                }
            }
        }
        //// update export
        private void saveExportBTN_Click(object sender, EventArgs e)
        {
            if (exportsDGV.SelectedRows.Count != 0)
            {
                decimal res;
                decimal.TryParse(exportsDGV.SelectedRows[0].Cells[4].Value.ToString(), out res);
                if ((int)exportQuantity.Value > ((int)currQuantity.Value + res))
                {
                    MessageBox.Show("This Quantity Is Not Available Right Now", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (stockListExported.SelectedIndex == -1 || itemListExported.SelectedIndex == -1 || exportsDGV.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("There Is Not Stock, Item Or No Selected Row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        int iteminstockid = (int)exportsDGV.SelectedRows[0].Cells[0].Value;
                        int qunatity = (int)exportQuantity.Value;
                        DateTime date = exportDate.Value;
                        ItemInStockServices.EditItemInStock(iteminstockid, qunatity, date);
                        exportsDGV.DataSource = ItemInStockServices.GetAllItemInStock((int?)stockListExported.SelectedValue, tabPage2.Text);
                        fillExport();
                        FillReport((int?)stockListReport.SelectedValue);
                    }
                }
            }
            else
            {
                MessageBox.Show("Theere Is No Selected Export", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //// delete export item
        private void deleteExportBTN_Click(object sender, EventArgs e)
        {
            if (stockListExported.SelectedIndex == -1 || itemListExported.SelectedIndex == -1 || exportsDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("There Is Not Stock, Item Or No Selected Row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int iteminstockid = (int)exportsDGV.SelectedRows[0].Cells[0].Value;
                ItemInStockServices.DeleteItemInStock(iteminstockid);
                exportsDGV.DataSource = ItemInStockServices.GetAllItemInStock((int?)stockListExported.SelectedValue, tabPage2.Text);
                fillExport();
            }
        }
        //// fill the data girdview contains reoport
        public void FillReport(int? stock_id)
        {
            reportDGV.Rows.Clear();
            foreach (Item item in ItemInStockServices.GetAllItemInStock(stock_id))
            {
                reportDGV.Rows.Add(item.Name, item.Category.Name, ItemServices.GetQuantity(item.ID, stock_id));
            }
        }
        //// when change stock in report
        private void stockListReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (stockListReport.SelectedIndex != -1)
            {
                FillReport((int)stockListReport.SelectedValue);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            importDate.Value = DateTime.Now;
            exportDate.Value = DateTime.Now;
        }


    }
}
