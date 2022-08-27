namespace Shoprite_Management_System
{
    partial class POS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gunaDataGridViewOrder = new Guna.UI.WinForms.GunaDataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.tbProdName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbBarcode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelBarcode = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonProd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelManageCategories = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCashName = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbQty = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaDataGridViewProd = new Guna.UI.WinForms.GunaDataGridView();
            this.PBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelOverallTtl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gunaDataGridViewTransaction = new Guna.UI.WinForms.GunaDataGridView();
            this.buttonAddTrans = new System.Windows.Forms.Button();
            this.labelTtlQty = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridViewOrder)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridViewProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridViewTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.labelTtlQty);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.buttonAddTrans);
            this.panel3.Controls.Add(this.gunaDataGridViewTransaction);
            this.panel3.Controls.Add(this.labelOverallTtl);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.gunaDataGridViewProd);
            this.panel3.Controls.Add(this.tbPrice);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tbQty);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.gunaDataGridViewOrder);
            this.panel3.Controls.Add(this.buttonSearch);
            this.panel3.Controls.Add(this.buttonAddProduct);
            this.panel3.Controls.Add(this.tbProdName);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.tbBarcode);
            this.panel3.Controls.Add(this.labelBarcode);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(97, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1507, 606);
            this.panel3.TabIndex = 10;
            // 
            // gunaDataGridViewOrder
            // 
            this.gunaDataGridViewOrder.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.gunaDataGridViewOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gunaDataGridViewOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridViewOrder.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridViewOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridViewOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridViewOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridViewOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gunaDataGridViewOrder.ColumnHeadersHeight = 32;
            this.gunaDataGridViewOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PBarcode,
            this.PName,
            this.PQuantity,
            this.PPrice,
            this.PSubtotal});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridViewOrder.DefaultCellStyle = dataGridViewCellStyle9;
            this.gunaDataGridViewOrder.EnableHeadersVisualStyles = false;
            this.gunaDataGridViewOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridViewOrder.Location = new System.Drawing.Point(403, 52);
            this.gunaDataGridViewOrder.Name = "gunaDataGridViewOrder";
            this.gunaDataGridViewOrder.RowHeadersVisible = false;
            this.gunaDataGridViewOrder.RowTemplate.Height = 30;
            this.gunaDataGridViewOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridViewOrder.Size = new System.Drawing.Size(467, 454);
            this.gunaDataGridViewOrder.TabIndex = 14;
            this.gunaDataGridViewOrder.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridViewOrder.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridViewOrder.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridViewOrder.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridViewOrder.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridViewOrder.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridViewOrder.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridViewOrder.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridViewOrder.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDataGridViewOrder.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridViewOrder.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDataGridViewOrder.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridViewOrder.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridViewOrder.ThemeStyle.HeaderStyle.Height = 32;
            this.gunaDataGridViewOrder.ThemeStyle.ReadOnly = false;
            this.gunaDataGridViewOrder.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridViewOrder.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridViewOrder.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDataGridViewOrder.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gunaDataGridViewOrder.ThemeStyle.RowsStyle.Height = 30;
            this.gunaDataGridViewOrder.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridViewOrder.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.gunaDataGridViewOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridViewOrder_CellContentClick);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonSearch.Location = new System.Drawing.Point(180, 279);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(150, 30);
            this.buttonSearch.TabIndex = 12;
            this.buttonSearch.Text = "Search Product";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonAddProduct.FlatAppearance.BorderSize = 0;
            this.buttonAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddProduct.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAddProduct.Location = new System.Drawing.Point(13, 279);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(150, 30);
            this.buttonAddProduct.TabIndex = 11;
            this.buttonAddProduct.Text = "Add Product";
            this.buttonAddProduct.UseVisualStyleBackColor = false;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonCatAdd_Click);
            // 
            // tbProdName
            // 
            this.tbProdName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbProdName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbProdName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbProdName.HintForeColor = System.Drawing.Color.Empty;
            this.tbProdName.HintText = "";
            this.tbProdName.isPassword = false;
            this.tbProdName.LineFocusedColor = System.Drawing.Color.Black;
            this.tbProdName.LineIdleColor = System.Drawing.Color.White;
            this.tbProdName.LineMouseHoverColor = System.Drawing.Color.Black;
            this.tbProdName.LineThickness = 3;
            this.tbProdName.Location = new System.Drawing.Point(137, 103);
            this.tbProdName.Margin = new System.Windows.Forms.Padding(4);
            this.tbProdName.Name = "tbProdName";
            this.tbProdName.Size = new System.Drawing.Size(193, 31);
            this.tbProdName.TabIndex = 4;
            this.tbProdName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Product Name";
            // 
            // tbBarcode
            // 
            this.tbBarcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbBarcode.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbBarcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbBarcode.HintForeColor = System.Drawing.Color.Empty;
            this.tbBarcode.HintText = "";
            this.tbBarcode.isPassword = false;
            this.tbBarcode.LineFocusedColor = System.Drawing.Color.Black;
            this.tbBarcode.LineIdleColor = System.Drawing.Color.White;
            this.tbBarcode.LineMouseHoverColor = System.Drawing.Color.Black;
            this.tbBarcode.LineThickness = 3;
            this.tbBarcode.Location = new System.Drawing.Point(137, 52);
            this.tbBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Size = new System.Drawing.Size(193, 31);
            this.tbBarcode.TabIndex = 2;
            this.tbBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelBarcode
            // 
            this.labelBarcode.AutoSize = true;
            this.labelBarcode.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBarcode.Location = new System.Drawing.Point(9, 62);
            this.labelBarcode.Name = "labelBarcode";
            this.labelBarcode.Size = new System.Drawing.Size(72, 21);
            this.labelBarcode.TabIndex = 1;
            this.labelBarcode.Text = "Barcode";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.buttonLogout);
            this.panel2.Controls.Add(this.buttonProd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(97, 606);
            this.panel2.TabIndex = 9;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLogout.Location = new System.Drawing.Point(12, 558);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(77, 32);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            // 
            // buttonProd
            // 
            this.buttonProd.FlatAppearance.BorderSize = 0;
            this.buttonProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonProd.Location = new System.Drawing.Point(12, 189);
            this.buttonProd.Name = "buttonProd";
            this.buttonProd.Size = new System.Drawing.Size(0, 0);
            this.buttonProd.TabIndex = 0;
            this.buttonProd.Text = "Product";
            this.buttonProd.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.labelDate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labelCashName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelManageCategories);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1604, 59);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelManageCategories
            // 
            this.labelManageCategories.AutoSize = true;
            this.labelManageCategories.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageCategories.Location = new System.Drawing.Point(495, 18);
            this.labelManageCategories.Name = "labelManageCategories";
            this.labelManageCategories.Size = new System.Drawing.Size(157, 28);
            this.labelManageCategories.TabIndex = 0;
            this.labelManageCategories.Text = "Manage Sales";
            this.labelManageCategories.Click += new System.EventHandler(this.labelManageCategories_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cashier:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelCashName
            // 
            this.labelCashName.AutoSize = true;
            this.labelCashName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCashName.Location = new System.Drawing.Point(90, 25);
            this.labelCashName.Name = "labelCashName";
            this.labelCashName.Size = new System.Drawing.Size(56, 21);
            this.labelCashName.TabIndex = 2;
            this.labelCashName.Text = "Name";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(1079, 26);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(46, 21);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1026, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date:";
            // 
            // tbPrice
            // 
            this.tbPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPrice.HintForeColor = System.Drawing.Color.Empty;
            this.tbPrice.HintText = "";
            this.tbPrice.isPassword = false;
            this.tbPrice.LineFocusedColor = System.Drawing.Color.Black;
            this.tbPrice.LineIdleColor = System.Drawing.Color.White;
            this.tbPrice.LineMouseHoverColor = System.Drawing.Color.Black;
            this.tbPrice.LineThickness = 3;
            this.tbPrice.Location = new System.Drawing.Point(137, 216);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(193, 31);
            this.tbPrice.TabIndex = 18;
            this.tbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Price";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbQty
            // 
            this.tbQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbQty.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbQty.HintForeColor = System.Drawing.Color.Empty;
            this.tbQty.HintText = "";
            this.tbQty.isPassword = false;
            this.tbQty.LineFocusedColor = System.Drawing.Color.Black;
            this.tbQty.LineIdleColor = System.Drawing.Color.White;
            this.tbQty.LineMouseHoverColor = System.Drawing.Color.Black;
            this.tbQty.LineThickness = 3;
            this.tbQty.Location = new System.Drawing.Point(137, 158);
            this.tbQty.Margin = new System.Windows.Forms.Padding(4);
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(193, 31);
            this.tbQty.TabIndex = 16;
            this.tbQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Quantity";
            // 
            // gunaDataGridViewProd
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gunaDataGridViewProd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gunaDataGridViewProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridViewProd.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridViewProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridViewProd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridViewProd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridViewProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gunaDataGridViewProd.ColumnHeadersHeight = 32;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridViewProd.DefaultCellStyle = dataGridViewCellStyle6;
            this.gunaDataGridViewProd.EnableHeadersVisualStyles = false;
            this.gunaDataGridViewProd.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridViewProd.Location = new System.Drawing.Point(13, 315);
            this.gunaDataGridViewProd.Name = "gunaDataGridViewProd";
            this.gunaDataGridViewProd.ReadOnly = true;
            this.gunaDataGridViewProd.RowHeadersVisible = false;
            this.gunaDataGridViewProd.RowTemplate.Height = 30;
            this.gunaDataGridViewProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridViewProd.Size = new System.Drawing.Size(379, 275);
            this.gunaDataGridViewProd.TabIndex = 19;
            this.gunaDataGridViewProd.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridViewProd.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridViewProd.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridViewProd.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridViewProd.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridViewProd.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridViewProd.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridViewProd.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridViewProd.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDataGridViewProd.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridViewProd.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDataGridViewProd.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridViewProd.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridViewProd.ThemeStyle.HeaderStyle.Height = 32;
            this.gunaDataGridViewProd.ThemeStyle.ReadOnly = true;
            this.gunaDataGridViewProd.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridViewProd.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridViewProd.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDataGridViewProd.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gunaDataGridViewProd.ThemeStyle.RowsStyle.Height = 30;
            this.gunaDataGridViewProd.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridViewProd.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.gunaDataGridViewProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridViewProd_CellContentClick);
            // 
            // PBarcode
            // 
            this.PBarcode.HeaderText = "Barcode";
            this.PBarcode.Name = "PBarcode";
            // 
            // PName
            // 
            this.PName.HeaderText = "ProdName";
            this.PName.Name = "PName";
            // 
            // PQuantity
            // 
            this.PQuantity.HeaderText = "ProdQty";
            this.PQuantity.Name = "PQuantity";
            // 
            // PPrice
            // 
            this.PPrice.HeaderText = "ProdPrice";
            this.PPrice.Name = "PPrice";
            // 
            // PSubtotal
            // 
            this.PSubtotal.HeaderText = "SubTotal";
            this.PSubtotal.Name = "PSubtotal";
            // 
            // labelOverallTtl
            // 
            this.labelOverallTtl.AutoSize = true;
            this.labelOverallTtl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOverallTtl.Location = new System.Drawing.Point(543, 540);
            this.labelOverallTtl.Name = "labelOverallTtl";
            this.labelOverallTtl.Size = new System.Drawing.Size(43, 21);
            this.labelOverallTtl.TabIndex = 21;
            this.labelOverallTtl.Text = "GHS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(403, 536);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 27);
            this.label7.TabIndex = 20;
            this.label7.Text = "Overall Total:";
            // 
            // gunaDataGridViewTransaction
            // 
            this.gunaDataGridViewTransaction.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunaDataGridViewTransaction.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDataGridViewTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridViewTransaction.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridViewTransaction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridViewTransaction.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridViewTransaction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridViewTransaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDataGridViewTransaction.ColumnHeadersHeight = 32;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridViewTransaction.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDataGridViewTransaction.EnableHeadersVisualStyles = false;
            this.gunaDataGridViewTransaction.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridViewTransaction.Location = new System.Drawing.Point(889, 52);
            this.gunaDataGridViewTransaction.Name = "gunaDataGridViewTransaction";
            this.gunaDataGridViewTransaction.ReadOnly = true;
            this.gunaDataGridViewTransaction.RowHeadersVisible = false;
            this.gunaDataGridViewTransaction.RowTemplate.Height = 30;
            this.gunaDataGridViewTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridViewTransaction.Size = new System.Drawing.Size(606, 229);
            this.gunaDataGridViewTransaction.TabIndex = 22;
            this.gunaDataGridViewTransaction.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridViewTransaction.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridViewTransaction.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridViewTransaction.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridViewTransaction.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridViewTransaction.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridViewTransaction.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridViewTransaction.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridViewTransaction.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDataGridViewTransaction.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridViewTransaction.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDataGridViewTransaction.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridViewTransaction.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridViewTransaction.ThemeStyle.HeaderStyle.Height = 32;
            this.gunaDataGridViewTransaction.ThemeStyle.ReadOnly = true;
            this.gunaDataGridViewTransaction.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridViewTransaction.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridViewTransaction.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDataGridViewTransaction.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gunaDataGridViewTransaction.ThemeStyle.RowsStyle.Height = 30;
            this.gunaDataGridViewTransaction.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridViewTransaction.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            // 
            // buttonAddTrans
            // 
            this.buttonAddTrans.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonAddTrans.FlatAppearance.BorderSize = 0;
            this.buttonAddTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddTrans.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAddTrans.Location = new System.Drawing.Point(720, 16);
            this.buttonAddTrans.Name = "buttonAddTrans";
            this.buttonAddTrans.Size = new System.Drawing.Size(150, 30);
            this.buttonAddTrans.TabIndex = 23;
            this.buttonAddTrans.Text = "Add Transaction";
            this.buttonAddTrans.UseVisualStyleBackColor = false;
            this.buttonAddTrans.Click += new System.EventHandler(this.buttonAddTrans_Click);
            // 
            // labelTtlQty
            // 
            this.labelTtlQty.AutoSize = true;
            this.labelTtlQty.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTtlQty.Location = new System.Drawing.Point(827, 540);
            this.labelTtlQty.Name = "labelTtlQty";
            this.labelTtlQty.Size = new System.Drawing.Size(34, 21);
            this.labelTtlQty.TabIndex = 26;
            this.labelTtlQty.Text = "qty";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(716, 536);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 27);
            this.label8.TabIndex = 25;
            this.label8.Text = "Total Qty:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(1345, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 30);
            this.button1.TabIndex = 27;
            this.button1.Text = "Print Receipt";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 665);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "POS";
            this.Text = "POS";
            this.Load += new System.EventHandler(this.POS_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridViewOrder)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridViewProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridViewTransaction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridViewOrder;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonAddProduct;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbProdName;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbBarcode;
        private System.Windows.Forms.Label labelBarcode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonProd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelManageCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCashName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbPrice;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbQty;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridViewProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn PBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PSubtotal;
        private System.Windows.Forms.Label labelOverallTtl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAddTrans;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridViewTransaction;
        private System.Windows.Forms.Label labelTtlQty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}