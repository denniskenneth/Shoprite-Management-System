using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoprite_Management_System
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        int strt = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            strt++;
            bunifuProgressBarSplash.Value = strt;
            if (bunifuProgressBarSplash.Value == 100)
            {
                bunifuProgressBarSplash.Value = 0;
                timerSplash.Stop();
                FormLogin login = new FormLogin();
                this.Hide();
                login.Show();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timerSplash.Start();
        }

        private void bunifuProgressBarSplash_progressChanged(object sender, EventArgs e)
        {

        }
    }
}
