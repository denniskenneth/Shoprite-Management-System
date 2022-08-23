using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shoprite_Management_System.Database;
using MySql.Data.MySqlClient;

namespace Shoprite_Management_System
{
    public partial class pos : Form
    {
        DBconn DBconn = new DBconn();
        public pos()
        {
            InitializeComponent();
            customDesign();
            DBconn.connMain = new MySqlConnection(DBconn.Connection());
            DBconn.connMain.Open();
            //MessageBox.Show("DB is Up");
            
        }

        // START - PANELLEFTSIDE
        private void customDesign()
        {
            panelSubProduct.Visible = false;
            panelSubRecord.Visible = false;
            panelSubSettings.Visible = false;
            panelSubStock.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panelSubProduct.Visible == true)
                panelSubProduct.Visible = false;
            if (panelSubRecord.Visible == true)
                panelSubRecord.Visible = false;
            if (panelSubSettings.Visible == true)
                panelSubSettings.Visible = false;
            if (panelSubStock.Visible == true)
                panelSubStock.Visible = false;
        }

        private void showSubmenu(Panel target)
        {
            if (target.Visible == false)
            {
                hideSubmenu();
                target.Visible = true;
            } else
            {
                target.Visible = false;
            }
        }
        //  END - PANELLEFTSIDE

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panelLeftSide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubProduct);
        }

        private void buttonStock_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubStock);
        }

        private void buttonRecord_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubRecord);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubSettings);
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void buttonSupplier_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
