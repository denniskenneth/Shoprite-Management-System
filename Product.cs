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

namespace Shoprite_Management_System
{
    public partial class Product : Form
    {
        DBconn dbconn = new DBconn();
        public Product()
        {
            InitializeComponent();
            dbconn.Open();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
