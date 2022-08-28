namespace Shoprite_Management_System
{
    partial class Splash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.labelSplashTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuProgressBarSplash = new Bunifu.Framework.UI.BunifuProgressBar();
            this.timerSplash = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelSplashTitle
            // 
            this.labelSplashTitle.AutoSize = true;
            this.labelSplashTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSplashTitle.Location = new System.Drawing.Point(228, 26);
            this.labelSplashTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSplashTitle.Name = "labelSplashTitle";
            this.labelSplashTitle.Size = new System.Drawing.Size(334, 28);
            this.labelSplashTitle.TabIndex = 9;
            this.labelSplashTitle.Text = "Shoprite Management System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "By 10807947";
            // 
            // bunifuProgressBarSplash
            // 
            this.bunifuProgressBarSplash.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bunifuProgressBarSplash.BorderRadius = 5;
            this.bunifuProgressBarSplash.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuProgressBarSplash.Location = new System.Drawing.Point(0, 440);
            this.bunifuProgressBarSplash.MaximumValue = 100;
            this.bunifuProgressBarSplash.Name = "bunifuProgressBarSplash";
            this.bunifuProgressBarSplash.ProgressColor = System.Drawing.Color.Black;
            this.bunifuProgressBarSplash.Size = new System.Drawing.Size(800, 10);
            this.bunifuProgressBarSplash.TabIndex = 11;
            this.bunifuProgressBarSplash.Value = 0;
            this.bunifuProgressBarSplash.progressChanged += new System.EventHandler(this.bunifuProgressBarSplash_progressChanged);
            // 
            // timerSplash
            // 
            this.timerSplash.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(159, 112);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 281);
            this.panel1.TabIndex = 12;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuProgressBarSplash);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSplashTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.Splash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSplashTitle;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBarSplash;
        private System.Windows.Forms.Timer timerSplash;
        private System.Windows.Forms.Panel panel1;
    }
}