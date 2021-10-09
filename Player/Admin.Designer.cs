
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.adminTabs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminTabs.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminTabs.Location = new System.Drawing.Point(0, 0);
            this.adminTabs.Name = "adminTabs";
            this.adminTabs.SelectedIndex = 0;
            this.adminTabs.Size = new System.Drawing.Size(611, 485);
            this.adminTabs.TabIndex = 0;
            // 
            // stockTab
            // 
            this.stockTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.stockTab.Controls.Add(this.button2);
            this.stockTab.Controls.Add(this.stockDGV);
            this.stockTab.Controls.Add(this.deleteStockBTN);
            this.stockTab.Controls.Add(this.saveStockBTN);
            this.stockTab.Controls.Add(this.addStockBTN);
            this.stockTab.Controls.Add(this.label1);
            this.stockTab.Controls.Add(this.stockNameTXT);
            this.stockTab.Location = new System.Drawing.Point(4, 30);
            this.stockTab.Name = "stockTab";
            this.stockTab.Padding = new System.Windows.Forms.Padding(3);
            this.stockTab.Size = new System.Drawing.Size(523, 451);
            this.stockTab.TabIndex = 0;
            this.stockTab.Text = "Stock";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stockDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.stockDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stockDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.stockDGV.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.stockDGV.Location = new System.Drawing.Point(174, 146);
            this.stockDGV.MultiSelect = false;
            this.stockDGV.Name = "stockDGV";
            this.stockDGV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stockDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.stockDGV.RowHeadersVisible = false;
            this.stockDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.stockDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.stockDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stockDGV.ShowCellToolTips = false;
            this.stockDGV.ShowEditingIcon = false;
            this.stockDGV.Size = new System.Drawing.Size(316, 244);
            this.stockDGV.TabIndex = 6;
            this.stockDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockDGV_CellContentClick);
            // 
            // deleteStockBTN
            // 
            this.deleteStockBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteStockBTN.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteStockBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.deleteStockBTN.Location = new System.Drawing.Point(411, 87);
            this.deleteStockBTN.Name = "deleteStockBTN";
            this.deleteStockBTN.Size = new System.Drawing.Size(79, 42);
            this.deleteStockBTN.TabIndex = 5;
            this.deleteStockBTN.Text = "Delete";
            this.deleteStockBTN.UseVisualStyleBackColor = true;
            this.deleteStockBTN.Click += new System.EventHandler(this.deleteStockBTN_Click);
            // 
            // saveStockBTN
            // 
            this.saveStockBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveStockBTN.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveStockBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.saveStockBTN.Location = new System.Drawing.Point(300, 87);
            this.saveStockBTN.Name = "saveStockBTN";
            this.saveStockBTN.Size = new System.Drawing.Size(79, 42);
            this.saveStockBTN.TabIndex = 4;
            this.saveStockBTN.Text = "Save";
            this.saveStockBTN.UseVisualStyleBackColor = true;
            this.saveStockBTN.Click += new System.EventHandler(this.saveStockBTN_Click);
            // 
            // addStockBTN
            // 
            this.addStockBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStockBTN.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStockBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.addStockBTN.Location = new System.Drawing.Point(174, 87);
            this.addStockBTN.Name = "addStockBTN";
            this.addStockBTN.Size = new System.Drawing.Size(79, 42);
            this.addStockBTN.TabIndex = 3;
            this.addStockBTN.Text = "Add";
            this.addStockBTN.UseVisualStyleBackColor = true;
            this.addStockBTN.Click += new System.EventHandler(this.addStockBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(41, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name :";
            // 
            // stockNameTXT
            // 
            this.stockNameTXT.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockNameTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.stockNameTXT.Location = new System.Drawing.Point(174, 31);
            this.stockNameTXT.Name = "stockNameTXT";
            this.stockNameTXT.Size = new System.Drawing.Size(316, 29);
            this.stockNameTXT.TabIndex = 0;
            // 
            // catTab
            // 
            this.catTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.catTab.Controls.Add(this.button1);
            this.catTab.Controls.Add(this.catDGV);
            this.catTab.Controls.Add(this.deleteCatBTN);
            this.catTab.Controls.Add(this.saveCatBTN);
            this.catTab.Controls.Add(this.addCatBTN);
            this.catTab.Controls.Add(this.label2);
            this.catTab.Controls.Add(this.catNameTXT);
            this.catTab.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catTab.Location = new System.Drawing.Point(4, 30);
            this.catTab.Name = "catTab";
            this.catTab.Padding = new System.Windows.Forms.Padding(3);
            this.catTab.Size = new System.Drawing.Size(523, 451);
            this.catTab.TabIndex = 1;
            this.catTab.Text = "Category";
            // 
            // catDGV
            // 
            this.catDGV.AllowUserToAddRows = false;
            this.catDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.catDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.catDGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.catDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.catDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.catDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.catDGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.catDGV.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.catDGV.Location = new System.Drawing.Point(161, 152);
            this.catDGV.MultiSelect = false;
            this.catDGV.Name = "catDGV";
            this.catDGV.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.catDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.catDGV.RowHeadersVisible = false;
            this.catDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.catDGV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.catDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.catDGV.ShowCellToolTips = false;
            this.catDGV.ShowEditingIcon = false;
            this.catDGV.Size = new System.Drawing.Size(310, 231);
            this.catDGV.TabIndex = 14;
            this.catDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.catDGV_CellContentClick);
            // 
            // deleteCatBTN
            // 
            this.deleteCatBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCatBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.deleteCatBTN.Location = new System.Drawing.Point(392, 91);
            this.deleteCatBTN.Name = "deleteCatBTN";
            this.deleteCatBTN.Size = new System.Drawing.Size(79, 37);
            this.deleteCatBTN.TabIndex = 11;
            this.deleteCatBTN.Text = "Delete";
            this.deleteCatBTN.UseVisualStyleBackColor = true;
            this.deleteCatBTN.Click += new System.EventHandler(this.deleteCatBTN_Click);
            // 
            // saveCatBTN
            // 
            this.saveCatBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveCatBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.saveCatBTN.Location = new System.Drawing.Point(277, 91);
            this.saveCatBTN.Name = "saveCatBTN";
            this.saveCatBTN.Size = new System.Drawing.Size(79, 37);
            this.saveCatBTN.TabIndex = 10;
            this.saveCatBTN.Text = "Save";
            this.saveCatBTN.UseVisualStyleBackColor = true;
            this.saveCatBTN.Click += new System.EventHandler(this.saveCatBTN_Click);
            // 
            // addCatBTN
            // 
            this.addCatBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCatBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.addCatBTN.Location = new System.Drawing.Point(161, 91);
            this.addCatBTN.Name = "addCatBTN";
            this.addCatBTN.Size = new System.Drawing.Size(79, 37);
            this.addCatBTN.TabIndex = 9;
            this.addCatBTN.Text = "Add";
            this.addCatBTN.UseVisualStyleBackColor = true;
            this.addCatBTN.Click += new System.EventHandler(this.addCatBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(48, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name :";
            // 
            // catNameTXT
            // 
            this.catNameTXT.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catNameTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.catNameTXT.Location = new System.Drawing.Point(161, 42);
            this.catNameTXT.Name = "catNameTXT";
            this.catNameTXT.Size = new System.Drawing.Size(310, 33);
            this.catNameTXT.TabIndex = 6;
            // 
            // itemTab
            // 
            this.itemTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.itemTab.Controls.Add(this.itemsDGV);
            this.itemTab.Controls.Add(this.importExportBTN);
            this.itemTab.Controls.Add(this.catList);
            this.itemTab.Controls.Add(this.label4);
            this.itemTab.Controls.Add(this.deleteItemBTN);
            this.itemTab.Controls.Add(this.saveItemBTN);
            this.itemTab.Controls.Add(this.addItenBTN);
            this.itemTab.Controls.Add(this.label5);
            this.itemTab.Controls.Add(this.itemNameTXT);
            this.itemTab.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTab.Location = new System.Drawing.Point(4, 30);
            this.itemTab.Name = "itemTab";
            this.itemTab.Padding = new System.Windows.Forms.Padding(3);
            this.itemTab.Size = new System.Drawing.Size(603, 451);
            this.itemTab.TabIndex = 2;
            this.itemTab.Text = "Item";
            // 
            // itemsDGV
            // 
            this.itemsDGV.AllowUserToAddRows = false;
            this.itemsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.itemsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.itemsDGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.itemsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.itemsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.itemsDGV.DefaultCellStyle = dataGridViewCellStyle8;
            this.itemsDGV.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.itemsDGV.Location = new System.Drawing.Point(210, 184);
            this.itemsDGV.MultiSelect = false;
            this.itemsDGV.Name = "itemsDGV";
            this.itemsDGV.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.itemsDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.itemsDGV.RowHeadersVisible = false;
            this.itemsDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.itemsDGV.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.itemsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemsDGV.ShowCellToolTips = false;
            this.itemsDGV.ShowEditingIcon = false;
            this.itemsDGV.Size = new System.Drawing.Size(321, 214);
            this.itemsDGV.TabIndex = 23;
            this.itemsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsDGV_CellContentClick);
            // 
            // importExportBTN
            // 
            this.importExportBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importExportBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.importExportBTN.Location = new System.Drawing.Point(221, 404);
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
            this.catList.Location = new System.Drawing.Point(210, 84);
            this.catList.Name = "catList";
            this.catList.Size = new System.Drawing.Size(321, 29);
            this.catList.TabIndex = 21;
            this.catList.SelectedIndexChanged += new System.EventHandler(this.catList_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(84, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Category :";
            // 
            // deleteItemBTN
            // 
            this.deleteItemBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteItemBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.deleteItemBTN.Location = new System.Drawing.Point(452, 131);
            this.deleteItemBTN.Name = "deleteItemBTN";
            this.deleteItemBTN.Size = new System.Drawing.Size(79, 37);
            this.deleteItemBTN.TabIndex = 19;
            this.deleteItemBTN.Text = "Delete";
            this.deleteItemBTN.UseVisualStyleBackColor = true;
            this.deleteItemBTN.Click += new System.EventHandler(this.deleteItemBTN_Click);
            // 
            // saveItemBTN
            // 
            this.saveItemBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveItemBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.saveItemBTN.Location = new System.Drawing.Point(338, 131);
            this.saveItemBTN.Name = "saveItemBTN";
            this.saveItemBTN.Size = new System.Drawing.Size(79, 37);
            this.saveItemBTN.TabIndex = 18;
            this.saveItemBTN.Text = "Save";
            this.saveItemBTN.UseVisualStyleBackColor = true;
            this.saveItemBTN.Click += new System.EventHandler(this.saveItemBTN_Click);
            // 
            // addItenBTN
            // 
            this.addItenBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addItenBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.addItenBTN.Location = new System.Drawing.Point(210, 131);
            this.addItenBTN.Name = "addItenBTN";
            this.addItenBTN.Size = new System.Drawing.Size(79, 37);
            this.addItenBTN.TabIndex = 17;
            this.addItenBTN.Text = "Add";
            this.addItenBTN.UseVisualStyleBackColor = true;
            this.addItenBTN.Click += new System.EventHandler(this.addItenBTN_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(84, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Name :";
            // 
            // itemNameTXT
            // 
            this.itemNameTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.itemNameTXT.Location = new System.Drawing.Point(210, 43);
            this.itemNameTXT.Name = "itemNameTXT";
            this.itemNameTXT.Size = new System.Drawing.Size(321, 29);
            this.itemNameTXT.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(227, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 40);
            this.button1.TabIndex = 23;
            this.button1.Text = "Import / Export";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.importExportBTN_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(231, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 40);
            this.button2.TabIndex = 23;
            this.button2.Text = "Import / Export";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.importExportBTN_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 485);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

