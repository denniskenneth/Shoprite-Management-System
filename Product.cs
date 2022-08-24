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
    public partial class Product : Form
    {
        DBconn dbconn = new DBconn();
        public Product()
        {
            InitializeComponent();
            
        }
        MySqlConnection conn = new MySqlConnection(DBconn.Connection());

        private void fillDropdown()
        {
            conn.Open();
            var query = "SELECT  `catName` FROM `category`";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("catName", typeof(string));
            dt.Load(reader);
            comboBoxCatRole.ValueMember = "catName";
            comboBoxCatRole.DataSource = dt;
            conn.Close();

        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Product_Load(object sender, EventArgs e)
        {
            fillDropdown();
        }
    }
}
