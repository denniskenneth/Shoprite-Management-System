namespace Shoprite_Management_System
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.labelUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelClose = new System.Windows.Forms.Label();
            this.labelLoginTitle = new System.Windows.Forms.Label();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(57, 157);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(82, 20);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username";
            this.labelUsername.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 277);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(173, 159);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(160, 26);
            this.textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(173, 205);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(160, 26);
            this.textBoxPassword.TabIndex = 4;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(57, 206);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(78, 20);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            this.labelPassword.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogin.Location = new System.Drawing.Point(61, 277);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(272, 35);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.labelClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(388, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 477);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.BackColor = System.Drawing.Color.Red;
            this.labelClose.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.Location = new System.Drawing.Point(346, 9);
            this.labelClose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(25, 26);
            this.labelClose.TabIndex = 10;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // labelLoginTitle
            // 
            this.labelLoginTitle.AutoSize = true;
            this.labelLoginTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginTitle.Location = new System.Drawing.Point(154, 67);
            this.labelLoginTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLoginTitle.Name = "labelLoginTitle";
            this.labelLoginTitle.Size = new System.Drawing.Size(65, 26);
            this.labelLoginTitle.TabIndex = 8;
            this.labelLoginTitle.Text = "Login";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "ADMIN",
            "CASHIER"});
            this.comboBoxRole.Location = new System.Drawing.Point(173, 114);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(160, 28);
            this.comboBoxRole.TabIndex = 9;
            this.comboBoxRole.Text = "Role";
            this.comboBoxRole.SelectedIndexChanged += new System.EventHandler(this.comboBoxRole_SelectedIndexChanged);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonClear.Location = new System.Drawing.Point(61, 333);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(272, 35);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(770, 477);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.labelLoginTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLogin";
            this.Text = "Shoprite - Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelLoginTitle;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Button buttonClear;
    }
}

