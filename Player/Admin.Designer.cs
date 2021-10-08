
namespace Player
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.adminTabs = new System.Windows.Forms.TabControl();
            this.stockTab = new System.Windows.Forms.TabPage();
            this.stockDGV = new System.Windows.Forms.DataGridView();
            this.deleteStockBTN = new System.Windows.Forms.Button();
            this.saveStockBTN = new System.Windows.Forms.Button();
            this.addStockBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.stockNameTXT = new System.Windows.Forms.TextBox();
            this.catTab = new System.Windows.Forms.TabPage();
            this.catDGV = new System.Windows.Forms.DataGridView();
            this.deleteCatBTN = new System.Windows.Forms.Button();
            this.saveCatBTN = new System.Windows.Forms.Button();
            this.addCatBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.catNameTXT = new System.Windows.Forms.TextBox();
            this.itemTab = new System.Windows.Forms.TabPage();
            this.itemsDGV = new System.Windows.Forms.DataGridView();
            this.importExportBTN = new System.Windows.Forms.Button();
            this.catList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.deleteItemBTN = new System.Windows.Forms.Button();
            this.saveItemBTN = new System.Windows.Forms.Button();
            this.addItenBTN = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.itemNameTXT = new System.Windows.Forms.TextBox();
            this.adminTabs.SuspendLayout();
            this.stockTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockDGV)).BeginInit();
            this.catTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catDGV)).BeginInit();
            this.itemTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // adminTabs
            // 
            this.adminTabs.Controls.Add(this.stockTab);
            this.adminTabs.Controls.Add(this.catTab);
            this.adminTabs.Controls.Add(this.itemTab);
            this.adminTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminTabs.Location = new System.Drawing.Point(0, 0);
            this.adminTabs.Name = "adminTabs";
            this.adminTabs.SelectedIndex = 0;
            this.adminTabs.Size = new System.Drawing.Size(531, 485);
            this.adminTabs.TabIndex = 0;
            // 
            // stockTab
            // 
            this.stockTab.Controls.Add(this.stockDGV);
            this.stockTab.Controls.Add(this.deleteStockBTN);
            this.stockTab.Controls.Add(this.saveStockBTN);
            this.stockTab.Controls.Add(this.addStockBTN);
            this.stockTab.Controls.Add(this.label1);
            this.stockTab.Controls.Add(this.stockNameTXT);
            this.stockTab.Location = new System.Drawing.Point(4, 29);
            this.stockTab.Name = "stockTab";
            this.stockTab.Padding = new System.Windows.Forms.Padding(3);
            this.stockTab.Size = new System.Drawing.Size(523, 452);
            this.stockTab.TabIndex = 0;
            this.stockTab.Text = "Stock";
            this.stockTab.UseVisualStyleBackColor = true;
            // 
            // stockDGV
            // 
            this.stockDGV.AllowUserToAddRows = false;
            this.stockDGV.AllowUserToDeleteRows = false;
            this.stockDGV.AllowUserToResizeColumns = false;
            this.stockDGV.AllowUserToResizeRows = false;
            this.stockDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stockDGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.stockDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stockDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.stockDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stockDGV.DefaultCellStyle = dataGridViewCellStyle23;
            this.stockDGV.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.stockDGV.Location = new System.Drawing.Point(152, 190);
            this.stockDGV.MultiSelect = false;
            this.stockDGV.Name = "stockDGV";
            this.stockDGV.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stockDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.stockDGV.RowHeadersVisible = false;
            this.stockDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.stockDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.stockDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stockDGV.ShowCellToolTips = false;
            this.stockDGV.ShowEditingIcon = false;
            this.stockDGV.Size = new System.Drawing.Size(226, 244);
            this.stockDGV.TabIndex = 6;
            this.stockDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockDGV_CellContentClick);
            // 
            // deleteStockBTN
            // 
            this.deleteStockBTN.Location = new System.Drawing.Point(384, 136);
            this.deleteStockBTN.Name = "deleteStockBTN";
            this.deleteStockBTN.Size = new System.Drawing.Size(79, 27);
            this.deleteStockBTN.TabIndex = 5;
            this.deleteStockBTN.Text = "Delete";
            this.deleteStockBTN.UseVisualStyleBackColor = true;
            this.deleteStockBTN.Click += new System.EventHandler(this.deleteStockBTN_Click);
            // 
            // saveStockBTN
            // 
            this.saveStockBTN.Location = new System.Drawing.Point(214, 136);
            this.saveStockBTN.Name = "saveStockBTN";
            this.saveStockBTN.Size = new System.Drawing.Size(79, 27);
            this.saveStockBTN.TabIndex = 4;
            this.saveStockBTN.Text = "Save";
            this.saveStockBTN.UseVisualStyleBackColor = true;
            this.saveStockBTN.Click += new System.EventHandler(this.saveStockBTN_Click);
            // 
            // addStockBTN
            // 
            this.addStockBTN.Location = new System.Drawing.Point(44, 136);
            this.addStockBTN.Name = "addStockBTN";
            this.addStockBTN.Size = new System.Drawing.Size(79, 27);
            this.addStockBTN.TabIndex = 3;
            this.addStockBTN.Text = "Add";
            this.addStockBTN.UseVisualStyleBackColor = true;
            this.addStockBTN.Click += new System.EventHandler(this.addStockBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name :";
            // 
            // stockNameTXT
            // 
            this.stockNameTXT.Location = new System.Drawing.Point(174, 66);
            this.stockNameTXT.Name = "stockNameTXT";
            this.stockNameTXT.Size = new System.Drawing.Size(293, 26);
            this.stockNameTXT.TabIndex = 0;
            // 
            // catTab
            // 
            this.catTab.Controls.Add(this.catDGV);
            this.catTab.Controls.Add(this.deleteCatBTN);
            this.catTab.Controls.Add(this.saveCatBTN);
            this.catTab.Controls.Add(this.addCatBTN);
            this.catTab.Controls.Add(this.label2);
            this.catTab.Controls.Add(this.catNameTXT);
            this.catTab.Location = new System.Drawing.Point(4, 29);
            this.catTab.Name = "catTab";
            this.catTab.Padding = new System.Windows.Forms.Padding(3);
            this.catTab.Size = new System.Drawing.Size(523, 452);
            this.catTab.TabIndex = 1;
            this.catTab.Text = "Category";
            this.catTab.UseVisualStyleBackColor = true;
            // 
            // catDGV
            // 
            this.catDGV.AllowUserToAddRows = false;
            this.catDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.catDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.catDGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.catDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.catDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.catDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.catDGV.DefaultCellStyle = dataGridViewCellStyle26;
            this.catDGV.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.catDGV.Location = new System.Drawing.Point(145, 195);
            this.catDGV.MultiSelect = false;
            this.catDGV.Name = "catDGV";
            this.catDGV.ReadOnly = true;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.catDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.catDGV.RowHeadersVisible = false;
            this.catDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.catDGV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.catDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.catDGV.ShowCellToolTips = false;
            this.catDGV.ShowEditingIcon = false;
            this.catDGV.Size = new System.Drawing.Size(237, 231);
            this.catDGV.TabIndex = 14;
            this.catDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.catDGV_CellContentClick);
            // 
            // deleteCatBTN
            // 
            this.deleteCatBTN.Location = new System.Drawing.Point(392, 133);
            this.deleteCatBTN.Name = "deleteCatBTN";
            this.deleteCatBTN.Size = new System.Drawing.Size(79, 27);
            this.deleteCatBTN.TabIndex = 11;
            this.deleteCatBTN.Text = "Delete";
            this.deleteCatBTN.UseVisualStyleBackColor = true;
            this.deleteCatBTN.Click += new System.EventHandler(this.deleteCatBTN_Click);
            // 
            // saveCatBTN
            // 
            this.saveCatBTN.Location = new System.Drawing.Point(222, 133);
            this.saveCatBTN.Name = "saveCatBTN";
            this.saveCatBTN.Size = new System.Drawing.Size(79, 27);
            this.saveCatBTN.TabIndex = 10;
            this.saveCatBTN.Text = "Save";
            this.saveCatBTN.UseVisualStyleBackColor = true;
            this.saveCatBTN.Click += new System.EventHandler(this.saveCatBTN_Click);
            // 
            // addCatBTN
            // 
            this.addCatBTN.Location = new System.Drawing.Point(52, 133);
            this.addCatBTN.Name = "addCatBTN";
            this.addCatBTN.Size = new System.Drawing.Size(79, 27);
            this.addCatBTN.TabIndex = 9;
            this.addCatBTN.Text = "Add";
            this.addCatBTN.UseVisualStyleBackColor = true;
            this.addCatBTN.Click += new System.EventHandler(this.addCatBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name :";
            // 
            // catNameTXT
            // 
            this.catNameTXT.Location = new System.Drawing.Point(180, 63);
            this.catNameTXT.Name = "catNameTXT";
            this.catNameTXT.Size = new System.Drawing.Size(293, 26);
            this.catNameTXT.TabIndex = 6;
            // 
            // itemTab
            // 
            this.itemTab.Controls.Add(this.itemsDGV);
            this.itemTab.Controls.Add(this.importExportBTN);
            this.itemTab.Controls.Add(this.catList);
            this.itemTab.Controls.Add(this.label4);
            this.itemTab.Controls.Add(this.deleteItemBTN);
            this.itemTab.Controls.Add(this.saveItemBTN);
            this.itemTab.Controls.Add(this.addItenBTN);
            this.itemTab.Controls.Add(this.label5);
            this.itemTab.Controls.Add(this.itemNameTXT);
            this.itemTab.Location = new System.Drawing.Point(4, 29);
            this.itemTab.Name = "itemTab";
            this.itemTab.Padding = new System.Windows.Forms.Padding(3);
            this.itemTab.Size = new System.Drawing.Size(523, 452);
            this.itemTab.TabIndex = 2;
            this.itemTab.Text = "Item";
            this.itemTab.UseVisualStyleBackColor = true;
            // 
            // itemsDGV
            // 
            this.itemsDGV.AllowUserToAddRows = false;
            this.itemsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.itemsDGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.itemsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.itemsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemsDGV.DefaultCellStyle = dataGridViewCellStyle20;
            this.itemsDGV.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.itemsDGV.Location = new System.Drawing.Point(162, 184);
            this.itemsDGV.MultiSelect = false;
            this.itemsDGV.Name = "itemsDGV";
            this.itemsDGV.ReadOnly = true;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemsDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.itemsDGV.RowHeadersVisible = false;
            this.itemsDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.itemsDGV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.itemsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemsDGV.ShowCellToolTips = false;
            this.itemsDGV.ShowEditingIcon = false;
            this.itemsDGV.Size = new System.Drawing.Size(207, 214);
            this.itemsDGV.TabIndex = 23;
            this.itemsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsDGV_CellContentClick);
            // 
            // importExportBTN
            // 
            this.importExportBTN.Location = new System.Drawing.Point(162, 404);
            this.importExportBTN.Name = "importExportBTN";
            this.importExportBTN.Size = new System.Drawing.Size(207, 40);
            this.importExportBTN.TabIndex = 22;
            this.importExportBTN.Text = "Import / Export";
            this.importExportBTN.UseVisualStyleBackColor = true;
            this.importExportBTN.Click += new System.EventHandler(this.importExportBTN_Click);
            // 
            // catList
            // 
            this.catList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.catList.FormattingEnabled = true;
            this.catList.Location = new System.Drawing.Point(191, 84);
            this.catList.Name = "catList";
            this.catList.Size = new System.Drawing.Size(292, 28);
            this.catList.TabIndex = 21;
            this.catList.SelectedIndexChanged += new System.EventHandler(this.catList_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Category :";
            // 
            // deleteItemBTN
            // 
            this.deleteItemBTN.Location = new System.Drawing.Point(404, 141);
            this.deleteItemBTN.Name = "deleteItemBTN";
            this.deleteItemBTN.Size = new System.Drawing.Size(79, 27);
            this.deleteItemBTN.TabIndex = 19;
            this.deleteItemBTN.Text = "Delete";
            this.deleteItemBTN.UseVisualStyleBackColor = true;
            this.deleteItemBTN.Click += new System.EventHandler(this.deleteItemBTN_Click);
            // 
            // saveItemBTN
            // 
            this.saveItemBTN.Location = new System.Drawing.Point(234, 141);
            this.saveItemBTN.Name = "saveItemBTN";
            this.saveItemBTN.Size = new System.Drawing.Size(79, 27);
            this.saveItemBTN.TabIndex = 18;
            this.saveItemBTN.Text = "Save";
            this.saveItemBTN.UseVisualStyleBackColor = true;
            this.saveItemBTN.Click += new System.EventHandler(this.saveItemBTN_Click);
            // 
            // addItenBTN
            // 
            this.addItenBTN.Location = new System.Drawing.Point(64, 141);
            this.addItenBTN.Name = "addItenBTN";
            this.addItenBTN.Size = new System.Drawing.Size(79, 27);
            this.addItenBTN.TabIndex = 17;
            this.addItenBTN.Text = "Add";
            this.addItenBTN.UseVisualStyleBackColor = true;
            this.addItenBTN.Click += new System.EventHandler(this.addItenBTN_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Name :";
            // 
            // itemNameTXT
            // 
            this.itemNameTXT.Location = new System.Drawing.Point(191, 46);
            this.itemNameTXT.Name = "itemNameTXT";
            this.itemNameTXT.Size = new System.Drawing.Size(293, 26);
            this.itemNameTXT.TabIndex = 14;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 485);
            this.Controls.Add(this.adminTabs);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.adminTabs.ResumeLayout(false);
            this.stockTab.ResumeLayout(false);
            this.stockTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockDGV)).EndInit();
            this.catTab.ResumeLayout(false);
            this.catTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catDGV)).EndInit();
            this.itemTab.ResumeLayout(false);
            this.itemTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl adminTabs;
        private System.Windows.Forms.TabPage stockTab;
        private System.Windows.Forms.TabPage catTab;
        private System.Windows.Forms.TabPage itemTab;
        private System.Windows.Forms.Button deleteStockBTN;
        private System.Windows.Forms.Button saveStockBTN;
        private System.Windows.Forms.Button addStockBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stockNameTXT;
        private System.Windows.Forms.Button deleteCatBTN;
        private System.Windows.Forms.Button saveCatBTN;
        private System.Windows.Forms.Button addCatBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox catNameTXT;
        private System.Windows.Forms.ComboBox catList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deleteItemBTN;
        private System.Windows.Forms.Button saveItemBTN;
        private System.Windows.Forms.Button addItenBTN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox itemNameTXT;
        private System.Windows.Forms.Button importExportBTN;
        private System.Windows.Forms.DataGridView stockDGV;
        private System.Windows.Forms.DataGridView catDGV;
        private System.Windows.Forms.DataGridView itemsDGV;
    }
}

