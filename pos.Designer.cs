namespace Shoprite_Management_System
{
    partial class pos
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
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelAdministrator = new System.Windows.Forms.Label();
            this.panelLeftSide = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.buttonProduct = new System.Windows.Forms.Button();
            this.panelSubProduct = new System.Windows.Forms.Panel();
            this.buttonBrand = new System.Windows.Forms.Button();
            this.buttonCategory = new System.Windows.Forms.Button();
            this.buttonProductList = new System.Windows.Forms.Button();
            this.buttonStock = new System.Windows.Forms.Button();
            this.panelSubStock = new System.Windows.Forms.Panel();
            this.buttonStockAdj = new System.Windows.Forms.Button();
            this.buttonStockEntry = new System.Windows.Forms.Button();
            this.buttonSupplier = new System.Windows.Forms.Button();
            this.buttonRecord = new System.Windows.Forms.Button();
            this.panelSubRecord = new System.Windows.Forms.Panel();
            this.buttonSalesRecord = new System.Windows.Forms.Button();
            this.buttonSalesHistory = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.panelSubSettings = new System.Windows.Forms.Panel();
            this.buttonStore = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelLogo.SuspendLayout();
            this.panelLeftSide.SuspendLayout();
            this.panelSubProduct.SuspendLayout();
            this.panelSubStock.SuspendLayout();
            this.panelSubRecord.SuspendLayout();
            this.panelSubSettings.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.labelName);
            this.panelLogo.Controls.Add(this.labelUsername);
            this.panelLogo.Controls.Add(this.labelAdministrator);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(2, 2);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(201, 124);
            this.panelLogo.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(32, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(67, 25);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(32, 49);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(105, 25);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Username";
            this.labelUsername.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelAdministrator
            // 
            this.labelAdministrator.AutoSize = true;
            this.labelAdministrator.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdministrator.Location = new System.Drawing.Point(22, 86);
            this.labelAdministrator.Name = "labelAdministrator";
            this.labelAdministrator.Size = new System.Drawing.Size(132, 25);
            this.labelAdministrator.TabIndex = 0;
            this.labelAdministrator.Text = "Adminstrator";
            this.labelAdministrator.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelLeftSide
            // 
            this.panelLeftSide.AutoScroll = true;
            this.panelLeftSide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeftSide.Controls.Add(this.panelLogo);
            this.panelLeftSide.Controls.Add(this.buttonDashboard);
            this.panelLeftSide.Controls.Add(this.buttonProduct);
            this.panelLeftSide.Controls.Add(this.panelSubProduct);
            this.panelLeftSide.Controls.Add(this.buttonStock);
            this.panelLeftSide.Controls.Add(this.panelSubStock);
            this.panelLeftSide.Controls.Add(this.buttonSupplier);
            this.panelLeftSide.Controls.Add(this.buttonRecord);
            this.panelLeftSide.Controls.Add(this.panelSubRecord);
            this.panelLeftSide.Controls.Add(this.buttonSettings);
            this.panelLeftSide.Controls.Add(this.panelSubSettings);
            this.panelLeftSide.Controls.Add(this.panel2);
            this.panelLeftSide.Controls.Add(this.buttonLogout);
            this.panelLeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftSide.Location = new System.Drawing.Point(0, 0);
            this.panelLeftSide.Margin = new System.Windows.Forms.Padding(2);
            this.panelLeftSide.Name = "panelLeftSide";
            this.panelLeftSide.Size = new System.Drawing.Size(225, 661);
            this.panelLeftSide.TabIndex = 0;
            this.panelLeftSide.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeftSide_Paint);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboard.ForeColor = System.Drawing.Color.Black;
            this.buttonDashboard.Location = new System.Drawing.Point(3, 131);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonDashboard.Size = new System.Drawing.Size(194, 45);
            this.buttonDashboard.TabIndex = 0;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // buttonProduct
            // 
            this.buttonProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProduct.FlatAppearance.BorderSize = 0;
            this.buttonProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProduct.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProduct.ForeColor = System.Drawing.Color.Black;
            this.buttonProduct.Location = new System.Drawing.Point(3, 182);
            this.buttonProduct.Name = "buttonProduct";
            this.buttonProduct.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonProduct.Size = new System.Drawing.Size(194, 45);
            this.buttonProduct.TabIndex = 1;
            this.buttonProduct.Text = "Product";
            this.buttonProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProduct.UseVisualStyleBackColor = true;
            this.buttonProduct.Click += new System.EventHandler(this.buttonProduct_Click);
            // 
            // panelSubProduct
            // 
            this.panelSubProduct.Controls.Add(this.buttonBrand);
            this.panelSubProduct.Controls.Add(this.buttonCategory);
            this.panelSubProduct.Controls.Add(this.buttonProductList);
            this.panelSubProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubProduct.Location = new System.Drawing.Point(3, 233);
            this.panelSubProduct.Name = "panelSubProduct";
            this.panelSubProduct.Size = new System.Drawing.Size(200, 136);
            this.panelSubProduct.TabIndex = 0;
            // 
            // buttonBrand
            // 
            this.buttonBrand.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonBrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBrand.FlatAppearance.BorderSize = 0;
            this.buttonBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrand.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrand.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonBrand.Location = new System.Drawing.Point(0, 90);
            this.buttonBrand.Name = "buttonBrand";
            this.buttonBrand.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonBrand.Size = new System.Drawing.Size(200, 45);
            this.buttonBrand.TabIndex = 4;
            this.buttonBrand.Text = "Brand";
            this.buttonBrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBrand.UseVisualStyleBackColor = false;
            // 
            // buttonCategory
            // 
            this.buttonCategory.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCategory.FlatAppearance.BorderSize = 0;
            this.buttonCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCategory.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCategory.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonCategory.Location = new System.Drawing.Point(0, 45);
            this.buttonCategory.Name = "buttonCategory";
            this.buttonCategory.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonCategory.Size = new System.Drawing.Size(200, 45);
            this.buttonCategory.TabIndex = 3;
            this.buttonCategory.Text = "Category";
            this.buttonCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCategory.UseVisualStyleBackColor = false;
            // 
            // buttonProductList
            // 
            this.buttonProductList.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonProductList.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProductList.FlatAppearance.BorderSize = 0;
            this.buttonProductList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProductList.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProductList.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonProductList.Location = new System.Drawing.Point(0, 0);
            this.buttonProductList.Name = "buttonProductList";
            this.buttonProductList.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonProductList.Size = new System.Drawing.Size(200, 45);
            this.buttonProductList.TabIndex = 2;
            this.buttonProductList.Text = "Product List";
            this.buttonProductList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProductList.UseVisualStyleBackColor = false;
            // 
            // buttonStock
            // 
            this.buttonStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStock.FlatAppearance.BorderSize = 0;
            this.buttonStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStock.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStock.ForeColor = System.Drawing.Color.Black;
            this.buttonStock.Location = new System.Drawing.Point(3, 375);
            this.buttonStock.Name = "buttonStock";
            this.buttonStock.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonStock.Size = new System.Drawing.Size(194, 45);
            this.buttonStock.TabIndex = 2;
            this.buttonStock.Text = "Stock";
            this.buttonStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStock.UseVisualStyleBackColor = true;
            this.buttonStock.Click += new System.EventHandler(this.buttonStock_Click);
            // 
            // panelSubStock
            // 
            this.panelSubStock.Controls.Add(this.buttonStockAdj);
            this.panelSubStock.Controls.Add(this.buttonStockEntry);
            this.panelSubStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubStock.Location = new System.Drawing.Point(3, 426);
            this.panelSubStock.Name = "panelSubStock";
            this.panelSubStock.Size = new System.Drawing.Size(200, 92);
            this.panelSubStock.TabIndex = 3;
            // 
            // buttonStockAdj
            // 
            this.buttonStockAdj.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonStockAdj.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStockAdj.FlatAppearance.BorderSize = 0;
            this.buttonStockAdj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStockAdj.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStockAdj.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonStockAdj.Location = new System.Drawing.Point(0, 45);
            this.buttonStockAdj.Name = "buttonStockAdj";
            this.buttonStockAdj.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonStockAdj.Size = new System.Drawing.Size(200, 45);
            this.buttonStockAdj.TabIndex = 3;
            this.buttonStockAdj.Text = "Stock Adjustment";
            this.buttonStockAdj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStockAdj.UseVisualStyleBackColor = false;
            // 
            // buttonStockEntry
            // 
            this.buttonStockEntry.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonStockEntry.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStockEntry.FlatAppearance.BorderSize = 0;
            this.buttonStockEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStockEntry.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStockEntry.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonStockEntry.Location = new System.Drawing.Point(0, 0);
            this.buttonStockEntry.Name = "buttonStockEntry";
            this.buttonStockEntry.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonStockEntry.Size = new System.Drawing.Size(200, 45);
            this.buttonStockEntry.TabIndex = 2;
            this.buttonStockEntry.Text = "Stock Entry";
            this.buttonStockEntry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStockEntry.UseVisualStyleBackColor = false;
            this.buttonStockEntry.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonSupplier
            // 
            this.buttonSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSupplier.FlatAppearance.BorderSize = 0;
            this.buttonSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupplier.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupplier.ForeColor = System.Drawing.Color.Black;
            this.buttonSupplier.Location = new System.Drawing.Point(3, 524);
            this.buttonSupplier.Name = "buttonSupplier";
            this.buttonSupplier.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonSupplier.Size = new System.Drawing.Size(194, 45);
            this.buttonSupplier.TabIndex = 4;
            this.buttonSupplier.Text = "Supplier";
            this.buttonSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSupplier.UseVisualStyleBackColor = true;
            this.buttonSupplier.Click += new System.EventHandler(this.buttonSupplier_Click);
            // 
            // buttonRecord
            // 
            this.buttonRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRecord.FlatAppearance.BorderSize = 0;
            this.buttonRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRecord.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecord.ForeColor = System.Drawing.Color.Black;
            this.buttonRecord.Location = new System.Drawing.Point(3, 575);
            this.buttonRecord.Name = "buttonRecord";
            this.buttonRecord.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonRecord.Size = new System.Drawing.Size(194, 45);
            this.buttonRecord.TabIndex = 5;
            this.buttonRecord.Text = "Record";
            this.buttonRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRecord.UseVisualStyleBackColor = true;
            this.buttonRecord.Click += new System.EventHandler(this.buttonRecord_Click);
            // 
            // panelSubRecord
            // 
            this.panelSubRecord.Controls.Add(this.buttonSalesRecord);
            this.panelSubRecord.Controls.Add(this.buttonSalesHistory);
            this.panelSubRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubRecord.Location = new System.Drawing.Point(3, 626);
            this.panelSubRecord.Name = "panelSubRecord";
            this.panelSubRecord.Size = new System.Drawing.Size(200, 92);
            this.panelSubRecord.TabIndex = 6;
            // 
            // buttonSalesRecord
            // 
            this.buttonSalesRecord.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonSalesRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSalesRecord.FlatAppearance.BorderSize = 0;
            this.buttonSalesRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalesRecord.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalesRecord.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSalesRecord.Location = new System.Drawing.Point(0, 45);
            this.buttonSalesRecord.Name = "buttonSalesRecord";
            this.buttonSalesRecord.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonSalesRecord.Size = new System.Drawing.Size(200, 45);
            this.buttonSalesRecord.TabIndex = 3;
            this.buttonSalesRecord.Text = "Sales Record";
            this.buttonSalesRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalesRecord.UseVisualStyleBackColor = false;
            // 
            // buttonSalesHistory
            // 
            this.buttonSalesHistory.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonSalesHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSalesHistory.FlatAppearance.BorderSize = 0;
            this.buttonSalesHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalesHistory.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalesHistory.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSalesHistory.Location = new System.Drawing.Point(0, 0);
            this.buttonSalesHistory.Name = "buttonSalesHistory";
            this.buttonSalesHistory.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonSalesHistory.Size = new System.Drawing.Size(200, 45);
            this.buttonSalesHistory.TabIndex = 2;
            this.buttonSalesHistory.Text = "Sales History";
            this.buttonSalesHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalesHistory.UseVisualStyleBackColor = false;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.ForeColor = System.Drawing.Color.Black;
            this.buttonSettings.Location = new System.Drawing.Point(3, 724);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonSettings.Size = new System.Drawing.Size(194, 45);
            this.buttonSettings.TabIndex = 7;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // panelSubSettings
            // 
            this.panelSubSettings.Controls.Add(this.buttonStore);
            this.panelSubSettings.Controls.Add(this.buttonUser);
            this.panelSubSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubSettings.Location = new System.Drawing.Point(3, 775);
            this.panelSubSettings.Name = "panelSubSettings";
            this.panelSubSettings.Size = new System.Drawing.Size(200, 92);
            this.panelSubSettings.TabIndex = 8;
            // 
            // buttonStore
            // 
            this.buttonStore.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonStore.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStore.FlatAppearance.BorderSize = 0;
            this.buttonStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStore.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStore.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonStore.Location = new System.Drawing.Point(0, 45);
            this.buttonStore.Name = "buttonStore";
            this.buttonStore.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonStore.Size = new System.Drawing.Size(200, 45);
            this.buttonStore.TabIndex = 3;
            this.buttonStore.Text = "Store";
            this.buttonStore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStore.UseVisualStyleBackColor = false;
            // 
            // buttonUser
            // 
            this.buttonUser.BackColor = System.Drawing.SystemColors.InfoText;
            this.buttonUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUser.FlatAppearance.BorderSize = 0;
            this.buttonUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUser.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonUser.Location = new System.Drawing.Point(0, 0);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonUser.Size = new System.Drawing.Size(200, 45);
            this.buttonUser.TabIndex = 2;
            this.buttonUser.Text = "User";
            this.buttonUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUser.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 873);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 0);
            this.panel2.TabIndex = 4;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.Black;
            this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLogout.Location = new System.Drawing.Point(3, 879);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonLogout.Size = new System.Drawing.Size(194, 45);
            this.buttonLogout.TabIndex = 9;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(225, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(959, 56);
            this.panelTitle.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(0, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(959, 37);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Title Name";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(225, 56);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(959, 605);
            this.panelMain.TabIndex = 2;
            // 
            // pos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelLeftSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "pos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point Of Sales";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelLeftSide.ResumeLayout(false);
            this.panelSubProduct.ResumeLayout(false);
            this.panelSubStock.ResumeLayout(false);
            this.panelSubRecord.ResumeLayout(false);
            this.panelSubSettings.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.FlowLayoutPanel panelLeftSide;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Button buttonProduct;
        private System.Windows.Forms.Panel panelSubProduct;
        private System.Windows.Forms.Button buttonBrand;
        private System.Windows.Forms.Button buttonCategory;
        private System.Windows.Forms.Button buttonProductList;
        private System.Windows.Forms.Button buttonStock;
        private System.Windows.Forms.Panel panelSubStock;
        private System.Windows.Forms.Button buttonStockAdj;
        private System.Windows.Forms.Button buttonStockEntry;
        private System.Windows.Forms.Button buttonSupplier;
        private System.Windows.Forms.Button buttonRecord;
        private System.Windows.Forms.Panel panelSubRecord;
        private System.Windows.Forms.Button buttonSalesRecord;
        private System.Windows.Forms.Button buttonSalesHistory;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Panel panelSubSettings;
        private System.Windows.Forms.Button buttonStore;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelAdministrator;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelTitle;
    }
}