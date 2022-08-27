namespace Shoprite_Management_System
{
    partial class Product
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelManageProduct = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCashier = new System.Windows.Forms.Button();
            this.buttonCategory = new System.Windows.Forms.Button();
            this.buttonProd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gunaDataGridViewProd = new Guna.UI.WinForms.GunaDataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxCatRole = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextboxPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextboxQty = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextboxName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextboxBarcode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridViewProd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.labelManageProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 59);
            this.panel1.TabIndex = 0;
            // 
            // labelManageProduct
            // 
            this.labelManageProduct.AutoSize = true;
            this.labelManageProduct.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageProduct.Location = new System.Drawing.Point(467, 19);
            this.labelManageProduct.Name = "labelManageProduct";
            this.labelManageProduct.Size = new System.Drawing.Size(199, 28);
            this.labelManageProduct.TabIndex = 0;
            this.labelManageProduct.Text = "Manage Products";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.buttonCashier);
            this.panel2.Controls.Add(this.buttonCategory);
            this.panel2.Controls.Add(this.buttonProd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(108, 602);
            this.panel2.TabIndex = 1;
            // 
            // buttonCashier
            // 
            this.buttonCashier.FlatAppearance.BorderSize = 0;
            this.buttonCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCashier.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonCashier.Location = new System.Drawing.Point(12, 132);
            this.buttonCashier.Name = "buttonCashier";
            this.buttonCashier.Size = new System.Drawing.Size(90, 32);
            this.buttonCashier.TabIndex = 2;
            this.buttonCashier.Text = "Cashier";
            this.buttonCashier.UseVisualStyleBackColor = true;
            this.buttonCashier.Click += new System.EventHandler(this.buttonCashier_Click);
            // 
            // buttonCategory
            // 
            this.buttonCategory.FlatAppearance.BorderSize = 0;
            this.buttonCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCategory.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonCategory.Location = new System.Drawing.Point(12, 195);
            this.buttonCategory.Name = "buttonCategory";
            this.buttonCategory.Size = new System.Drawing.Size(90, 32);
            this.buttonCategory.TabIndex = 1;
            this.buttonCategory.Text = "Category";
            this.buttonCategory.UseVisualStyleBackColor = true;
            this.buttonCategory.Click += new System.EventHandler(this.buttonCategory_Click);
            // 
            // buttonProd
            // 
            this.buttonProd.FlatAppearance.BorderSize = 0;
            this.buttonProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonProd.Location = new System.Drawing.Point(12, 62);
            this.buttonProd.Name = "buttonProd";
            this.buttonProd.Size = new System.Drawing.Size(90, 32);
            this.buttonProd.TabIndex = 0;
            this.buttonProd.Text = "Product";
            this.buttonProd.UseVisualStyleBackColor = true;
            this.buttonProd.Click += new System.EventHandler(this.buttonProd_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.gunaDataGridViewProd);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.buttonDelete);
            this.panel3.Controls.Add(this.buttonEdit);
            this.panel3.Controls.Add(this.buttonAdd);
            this.panel3.Controls.Add(this.comboBoxCatRole);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.bunifuMaterialTextboxPrice);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.bunifuMaterialTextboxQty);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.bunifuMaterialTextboxName);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.bunifuMaterialTextboxBarcode);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(108, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1076, 602);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // gunaDataGridViewProd
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunaDataGridViewProd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDataGridViewProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridViewProd.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridViewProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridViewProd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridViewProd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridViewProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDataGridViewProd.ColumnHeadersHeight = 32;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridViewProd.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDataGridViewProd.EnableHeadersVisualStyles = false;
            this.gunaDataGridViewProd.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridViewProd.Location = new System.Drawing.Point(448, 89);
            this.gunaDataGridViewProd.Name = "gunaDataGridViewProd";
            this.gunaDataGridViewProd.RowHeadersVisible = false;
            this.gunaDataGridViewProd.RowTemplate.Height = 30;
            this.gunaDataGridViewProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridViewProd.Size = new System.Drawing.Size(601, 443);
            this.gunaDataGridViewProd.TabIndex = 17;
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
            this.gunaDataGridViewProd.ThemeStyle.ReadOnly = false;
            this.gunaDataGridViewProd.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridViewProd.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridViewProd.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDataGridViewProd.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gunaDataGridViewProd.ThemeStyle.RowsStyle.Height = 30;
            this.gunaDataGridViewProd.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridViewProd.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.gunaDataGridViewProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridViewProd_CellContentClick);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button7.Location = new System.Drawing.Point(666, 54);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(106, 29);
            this.button7.TabIndex = 16;
            this.button7.Text = "Refresh";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 21;
            this.comboBox1.Items.AddRange(new object[] {
            "ADMIN",
            "CASHIER"});
            this.comboBox1.Location = new System.Drawing.Point(448, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 29);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.Text = "Select Category";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonDelete.Location = new System.Drawing.Point(234, 332);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(90, 32);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonEdit.Location = new System.Drawing.Point(127, 332);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(90, 32);
            this.buttonEdit.TabIndex = 12;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAdd.Location = new System.Drawing.Point(22, 332);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(90, 32);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxCatRole
            // 
            this.comboBoxCatRole.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCatRole.FormattingEnabled = true;
            this.comboBoxCatRole.Items.AddRange(new object[] {
            "ADMIN",
            "CASHIER"});
            this.comboBoxCatRole.Location = new System.Drawing.Point(112, 265);
            this.comboBoxCatRole.Name = "comboBoxCatRole";
            this.comboBoxCatRole.Size = new System.Drawing.Size(212, 28);
            this.comboBoxCatRole.TabIndex = 10;
            this.comboBoxCatRole.Text = "Select Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Category";
            // 
            // bunifuMaterialTextboxPrice
            // 
            this.bunifuMaterialTextboxPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextboxPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextboxPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextboxPrice.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextboxPrice.HintText = "";
            this.bunifuMaterialTextboxPrice.isPassword = false;
            this.bunifuMaterialTextboxPrice.LineFocusedColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextboxPrice.LineIdleColor = System.Drawing.Color.White;
            this.bunifuMaterialTextboxPrice.LineMouseHoverColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextboxPrice.LineThickness = 3;
            this.bunifuMaterialTextboxPrice.Location = new System.Drawing.Point(112, 216);
            this.bunifuMaterialTextboxPrice.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextboxPrice.Name = "bunifuMaterialTextboxPrice";
            this.bunifuMaterialTextboxPrice.Size = new System.Drawing.Size(212, 31);
            this.bunifuMaterialTextboxPrice.TabIndex = 8;
            this.bunifuMaterialTextboxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price";
            // 
            // bunifuMaterialTextboxQty
            // 
            this.bunifuMaterialTextboxQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextboxQty.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextboxQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextboxQty.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextboxQty.HintText = "";
            this.bunifuMaterialTextboxQty.isPassword = false;
            this.bunifuMaterialTextboxQty.LineFocusedColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextboxQty.LineIdleColor = System.Drawing.Color.White;
            this.bunifuMaterialTextboxQty.LineMouseHoverColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextboxQty.LineThickness = 3;
            this.bunifuMaterialTextboxQty.Location = new System.Drawing.Point(112, 158);
            this.bunifuMaterialTextboxQty.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextboxQty.Name = "bunifuMaterialTextboxQty";
            this.bunifuMaterialTextboxQty.Size = new System.Drawing.Size(212, 31);
            this.bunifuMaterialTextboxQty.TabIndex = 6;
            this.bunifuMaterialTextboxQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantity";
            // 
            // bunifuMaterialTextboxName
            // 
            this.bunifuMaterialTextboxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextboxName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextboxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextboxName.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextboxName.HintText = "";
            this.bunifuMaterialTextboxName.isPassword = false;
            this.bunifuMaterialTextboxName.LineFocusedColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextboxName.LineIdleColor = System.Drawing.Color.White;
            this.bunifuMaterialTextboxName.LineMouseHoverColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextboxName.LineThickness = 3;
            this.bunifuMaterialTextboxName.Location = new System.Drawing.Point(112, 103);
            this.bunifuMaterialTextboxName.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextboxName.Name = "bunifuMaterialTextboxName";
            this.bunifuMaterialTextboxName.Size = new System.Drawing.Size(212, 31);
            this.bunifuMaterialTextboxName.TabIndex = 4;
            this.bunifuMaterialTextboxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // bunifuMaterialTextboxBarcode
            // 
            this.bunifuMaterialTextboxBarcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextboxBarcode.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextboxBarcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextboxBarcode.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextboxBarcode.HintText = "";
            this.bunifuMaterialTextboxBarcode.isPassword = false;
            this.bunifuMaterialTextboxBarcode.LineFocusedColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextboxBarcode.LineIdleColor = System.Drawing.Color.White;
            this.bunifuMaterialTextboxBarcode.LineMouseHoverColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextboxBarcode.LineThickness = 3;
            this.bunifuMaterialTextboxBarcode.Location = new System.Drawing.Point(112, 52);
            this.bunifuMaterialTextboxBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextboxBarcode.Name = "bunifuMaterialTextboxBarcode";
            this.bunifuMaterialTextboxBarcode.Size = new System.Drawing.Size(212, 31);
            this.bunifuMaterialTextboxBarcode.TabIndex = 2;
            this.bunifuMaterialTextboxBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barcode";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Product";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridViewProd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelManageProduct;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonProd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonCashier;
        private System.Windows.Forms.Button buttonCategory;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxBarcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxPrice;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxQty;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxCatRole;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridViewProd;
    }
}