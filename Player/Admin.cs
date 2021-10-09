using BLLayer;
using DBLayer;
using System;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms;

namespace Player
{
    public partial class Admin : Form
    {
        StockServices StockServices;
        CategoryServices CategoryServices;
        ItemServices ItemServices;
        public Admin()
        {
            InitializeComponent();
            StockServices = new StockServices();
            CategoryServices = new CategoryServices();
            ItemServices = new ItemServices();
            FillComponents();


        }
        // fill all controls with data
        void FillComponents()
        {
            stockDGV.DataSource = StockServices.GetStocks();
            catDGV.DataSource = CategoryServices.GetAllCategories();
            catList.DisplayMember = "Name";
            catList.ValueMember = "ID";
            catList.DataSource = CategoryServices.GetAllCategories();
            itemsDGV.DataSource = ItemServices.GetAllItemsByCatID((int?)catList.SelectedValue);
            itemsDGV.Columns[0].Visible = false;
            itemsDGV.Columns[2].Visible = false;
            itemsDGV.Columns[3].Visible = false;
            stockDGV.Columns[0].Visible = false;
            catDGV.Columns[0].Visible = false;
        }
        // add stock
        private void addStockBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (stockNameTXT.Text == "")
                {
                    MessageBox.Show("Please Enter Stock Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.StockServices.AddStock(new Stock() { Name = stockNameTXT.Text });
                    stockDGV.DataSource = StockServices.GetStocks();
                    stockNameTXT.Text = "";
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Duplicated Stock Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                stockNameTXT.Text="";
            }

        }
        // save stock
        private void saveStockBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (stockNameTXT.Text == "")
                {
                    MessageBox.Show("Please Enter Stock Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    StockServices.EditStock(
                    (int)stockDGV.SelectedRows[0].Cells[0].Value, stockNameTXT.Text);
                    stockDGV.DataSource = StockServices.GetStocks();
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show("Duplicated Stock Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                stockNameTXT.Text = "";
            }

        }
        // delete stock
        private void deleteStockBTN_Click(object sender, EventArgs e)
        {
            if (stockDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select Stock", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                StockServices.DeleteStock((int)stockDGV.SelectedRows[0].Cells[0].Value);
                stockDGV.DataSource = StockServices.GetStocks();
                stockNameTXT.Text = "";
            }

        }
        // when select from stock dgv
        private void stockDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (stockDGV.SelectedRows.Count > 0)
            {
                stockNameTXT.Text = stockDGV.SelectedRows[0].Cells[1].Value.ToString();
            }
        }
        // add category
        private void addCatBTN_Click(object sender, EventArgs e)
        {
            try { 
                if (catNameTXT.Text == "")
                {
                    MessageBox.Show("Please Enter Category Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CategoryServices.AddCategory(new Category()
                    {
                        Name = catNameTXT.Text
                    });
                    catDGV.DataSource = CategoryServices.GetAllCategories();
                    catList.DisplayMember = "Name";
                    catList.ValueMember = "ID";
                    catList.DataSource = CategoryServices.GetAllCategories();
                    itemsDGV.DataSource = ItemServices.GetAllItemsByCatID((int?)catList.SelectedValue);
                }
            }catch (DbUpdateException ex)
            {
                MessageBox.Show("Duplicated Category Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                catNameTXT.Text = "";
            }
        }
        // edit category
        private void saveCatBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (catNameTXT.Text == "")
                {
                    MessageBox.Show("Please Enter Category Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int cat_id = (int)catDGV.SelectedRows[0].Cells[0].Value;
                    string catName = catNameTXT.Text;
                    CategoryServices.EditCategory(cat_id, catName);
                    catDGV.DataSource = CategoryServices.GetAllCategories();
                    catList.DisplayMember = "Name";
                    catList.ValueMember = "ID";
                    catList.DataSource = CategoryServices.GetAllCategories();
                    itemsDGV.DataSource = ItemServices.GetAllItemsByCatID((int?)catList.SelectedValue);
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Duplicated Category Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                catNameTXT.Text = "";
            }


        }
        // delete category
        private void deleteCatBTN_Click(object sender, EventArgs e)
        {
            if (catDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Enter Select Category", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int cat_id = (int)catDGV.SelectedRows[0].Cells[0].Value;
                CategoryServices.DeleteCategory(cat_id);
                catDGV.DataSource = CategoryServices.GetAllCategories();
                catList.DisplayMember = "Name";
                catList.ValueMember = "ID";
                catList.DataSource = CategoryServices.GetAllCategories();
                itemsDGV.DataSource = ItemServices.GetAllItemsByCatID((int?)catList.SelectedValue);
                catNameTXT.Text = "";
            }
        }
        // when select from category dgv
        private void catDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (catDGV.SelectedRows.Count > 0)
            {
                catNameTXT.Text = catDGV.SelectedRows[0].Cells[1].Value.ToString();
            }
        }
        // add item
        private void addItenBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (itemNameTXT.Text == "" || catList.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Enter Item Name and Select Category", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string item_name = itemNameTXT.Text;
                    int cat_id = (int)catList.SelectedValue;
                    ItemServices.AddItem(new Item()
                    {
                        Name = item_name,
                        Cat_ID = cat_id
                    });
                    itemsDGV.DataSource = ItemServices.GetAllItemsByCatID((int?)catList.SelectedValue);
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Duplicated Item Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                itemNameTXT.Text = "";
            }


        }
        // save item
        private void saveItemBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (itemNameTXT.Text == "" || catList.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Enter Item Name and Select Category", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int cat_id = (int)catList.SelectedValue;
                    int item_id = (int)itemsDGV.SelectedRows[0].Cells[0].Value;
                    string itemName = itemNameTXT.Text;
                    ItemServices.EditItem(item_id, cat_id);
                    ItemServices.EditItem(item_id, itemName);
                    itemsDGV.DataSource = ItemServices.GetAllItemsByCatID((int?)catList.SelectedValue);
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Duplicated Item Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                stockNameTXT.Text = "";
            }
            finally
            {
                itemNameTXT.Text = "";
            }

        }
        // delete item
        private void deleteItemBTN_Click(object sender, EventArgs e)
        {
            if (itemNameTXT.Text == "" || catList.SelectedIndex == -1 || itemsDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Enter Select Item ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int item_id = (int)itemsDGV.SelectedRows[0].Cells[0].Value;
                ItemServices.DeleteItem(item_id);
                itemsDGV.DataSource = ItemServices.GetAllItemsByCatID((int?)catList.SelectedValue);
                itemNameTXT.Text = "" ;
            }
        }
        // when change category list item
        private void catList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (catList.SelectedIndex != -1)
            {
                itemsDGV.DataSource = ItemServices.GetAllItemsByCatID((int)catList.SelectedValue);
            }
            itemNameTXT.Text = "";
        }
        // when select on item dgv
        private void itemsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (itemsDGV.SelectedRows.Count > 0)
            {
                itemNameTXT.Text = itemsDGV.SelectedRows[0].Cells[1].Value.ToString();
            }
        }
        // go to import/export from
        private void importExportBTN_Click(object sender, EventArgs e)
        {
            new ImportAndExport().ShowDialog();
        }
    }
}
