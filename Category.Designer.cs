namespace Shoprite_Management_System
{
    partial class Category
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelManageCategories = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gunaDataGridViewCat = new Guna.UI.WinForms.GunaDataGridView();
            this.buttonCatDelete = new System.Windows.Forms.Button();
            this.buttonCatEdit = new System.Windows.Forms.Button();
            this.buttonCatAdd = new System.Windows.Forms.Button();
            this.tbCatDesc = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCatName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCatId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridViewCat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.labelManageCategories);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 59);
            this.panel1.TabIndex = 1;
            // 
            // labelManageCategories
            // 
            this.labelManageCategories.AutoSize = true;
            this.labelManageCategories.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageCategories.Location = new System.Drawing.Point(467, 19);
            this.labelManageCategories.Name = "labelManageCategories";
            this.labelManageCategories.Size = new System.Drawing.Size(216, 28);
            this.labelManageCategories.TabIndex = 0;
            this.labelManageCategories.Text = "Manage Categories";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(108, 602);
            this.panel2.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Location = new System.Drawing.Point(12, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 32);
            this.button3.TabIndex = 2;
            this.button3.Text = "Cashier";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(12, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Category";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(12, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Product";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.gunaDataGridViewCat);
            this.panel3.Controls.Add(this.buttonCatDelete);
            this.panel3.Controls.Add(this.buttonCatEdit);
            this.panel3.Controls.Add(this.buttonCatAdd);
            this.panel3.Controls.Add(this.tbCatDesc);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tbCatName);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.tbCatId);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(108, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1076, 602);
            this.panel3.TabIndex = 7;
            // 
            // gunaDataGridViewCat
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gunaDataGridViewCat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gunaDataGridViewCat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridViewCat.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridViewCat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridViewCat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridViewCat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridViewCat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gunaDataGridViewCat.ColumnHeadersHeight = 32;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridViewCat.DefaultCellStyle = dataGridViewCellStyle6;
            this.gunaDataGridViewCat.EnableHeadersVisualStyles = false;
            this.gunaDataGridViewCat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridViewCat.Location = new System.Drawing.Point(448, 86);
            this.gunaDataGridViewCat.Name = "gunaDataGridViewCat";
            this.gunaDataGridViewCat.RowHeadersVisible = false;
            this.gunaDataGridViewCat.RowTemplate.Height = 30;
            this.gunaDataGridViewCat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridViewCat.Size = new System.Drawing.Size(601, 443);
            this.gunaDataGridViewCat.TabIndex = 14;
            this.gunaDataGridViewCat.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridViewCat.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridViewCat.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridViewCat.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridViewCat.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridViewCat.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridViewCat.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridViewCat.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridViewCat.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDataGridViewCat.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridViewCat.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDataGridViewCat.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridViewCat.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridViewCat.ThemeStyle.HeaderStyle.Height = 32;
            this.gunaDataGridViewCat.ThemeStyle.ReadOnly = false;
            this.gunaDataGridViewCat.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridViewCat.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridViewCat.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDataGridViewCat.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gunaDataGridViewCat.ThemeStyle.RowsStyle.Height = 30;
            this.gunaDataGridViewCat.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridViewCat.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.gunaDataGridViewCat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridViewCat_CellContentClick);
            // 
            // buttonCatDelete
            // 
            this.buttonCatDelete.BackColor = System.Drawing.Color.Red;
            this.buttonCatDelete.FlatAppearance.BorderSize = 0;
            this.buttonCatDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCatDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCatDelete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonCatDelete.Location = new System.Drawing.Point(234, 332);
            this.buttonCatDelete.Name = "buttonCatDelete";
            this.buttonCatDelete.Size = new System.Drawing.Size(90, 32);
            this.buttonCatDelete.TabIndex = 13;
            this.buttonCatDelete.Text = "Delete";
            this.buttonCatDelete.UseVisualStyleBackColor = false;
            this.buttonCatDelete.Click += new System.EventHandler(this.buttonCatDelete_Click);
            // 
            // buttonCatEdit
            // 
            this.buttonCatEdit.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonCatEdit.FlatAppearance.BorderSize = 0;
            this.buttonCatEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCatEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCatEdit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonCatEdit.Location = new System.Drawing.Point(127, 332);
            this.buttonCatEdit.Name = "buttonCatEdit";
            this.buttonCatEdit.Size = new System.Drawing.Size(90, 32);
            this.buttonCatEdit.TabIndex = 12;
            this.buttonCatEdit.Text = "Edit";
            this.buttonCatEdit.UseVisualStyleBackColor = false;
            this.buttonCatEdit.Click += new System.EventHandler(this.buttonCatEdit_Click);
            // 
            // buttonCatAdd
            // 
            this.buttonCatAdd.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonCatAdd.FlatAppearance.BorderSize = 0;
            this.buttonCatAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCatAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCatAdd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonCatAdd.Location = new System.Drawing.Point(22, 332);
            this.buttonCatAdd.Name = "buttonCatAdd";
            this.buttonCatAdd.Size = new System.Drawing.Size(90, 32);
            this.buttonCatAdd.TabIndex = 11;
            this.buttonCatAdd.Text = "Add";
            this.buttonCatAdd.UseVisualStyleBackColor = false;
            this.buttonCatAdd.Click += new System.EventHandler(this.buttonCatAdd_Click);
            // 
            // tbCatDesc
            // 
            this.tbCatDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCatDesc.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbCatDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbCatDesc.HintForeColor = System.Drawing.Color.Empty;
            this.tbCatDesc.HintText = "";
            this.tbCatDesc.isPassword = false;
            this.tbCatDesc.LineFocusedColor = System.Drawing.Color.Black;
            this.tbCatDesc.LineIdleColor = System.Drawing.Color.White;
            this.tbCatDesc.LineMouseHoverColor = System.Drawing.Color.Black;
            this.tbCatDesc.LineThickness = 3;
            this.tbCatDesc.Location = new System.Drawing.Point(121, 158);
            this.tbCatDesc.Margin = new System.Windows.Forms.Padding(4);
            this.tbCatDesc.Name = "tbCatDesc";
            this.tbCatDesc.Size = new System.Drawing.Size(203, 31);
            this.tbCatDesc.TabIndex = 6;
            this.tbCatDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // tbCatName
            // 
            this.tbCatName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCatName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbCatName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbCatName.HintForeColor = System.Drawing.Color.Empty;
            this.tbCatName.HintText = "";
            this.tbCatName.isPassword = false;
            this.tbCatName.LineFocusedColor = System.Drawing.Color.Black;
            this.tbCatName.LineIdleColor = System.Drawing.Color.White;
            this.tbCatName.LineMouseHoverColor = System.Drawing.Color.Black;
            this.tbCatName.LineThickness = 3;
            this.tbCatName.Location = new System.Drawing.Point(112, 103);
            this.tbCatName.Margin = new System.Windows.Forms.Padding(4);
            this.tbCatName.Name = "tbCatName";
            this.tbCatName.Size = new System.Drawing.Size(212, 31);
            this.tbCatName.TabIndex = 4;
            this.tbCatName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "Name";
            // 
            // tbCatId
            // 
            this.tbCatId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCatId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbCatId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbCatId.HintForeColor = System.Drawing.Color.Empty;
            this.tbCatId.HintText = "";
            this.tbCatId.isPassword = false;
            this.tbCatId.LineFocusedColor = System.Drawing.Color.Black;
            this.tbCatId.LineIdleColor = System.Drawing.Color.White;
            this.tbCatId.LineMouseHoverColor = System.Drawing.Color.Black;
            this.tbCatId.LineThickness = 3;
            this.tbCatId.Location = new System.Drawing.Point(112, 52);
            this.tbCatId.Margin = new System.Windows.Forms.Padding(4);
            this.tbCatId.Name = "tbCatId";
            this.tbCatId.Size = new System.Drawing.Size(212, 31);
            this.tbCatId.TabIndex = 2;
            this.tbCatId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "ID";
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Category";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridViewCat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelManageCategories;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridViewCat;
        private System.Windows.Forms.Button buttonCatDelete;
        private System.Windows.Forms.Button buttonCatEdit;
        private System.Windows.Forms.Button buttonCatAdd;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbCatDesc;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbCatName;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbCatId;
        private System.Windows.Forms.Label label7;
    }
}