using Shoprite_Management_System.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Shoprite_Management_System
{
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }
        DBconn dbconn = new DBconn();
        private void buttonCatAdd_Click(object sender, EventArgs e)
        {
            try
            {
                dbconn.Open();
                string query = $"INSERT INTO `category`( `catName`, `catDescription`) VALUES ('{tbCatName.Text.ToLower()}','{tbCatDesc.Text.ToLower()}')";
                dbconn.Query(query);
                MessageBox.Show("Category Added Successfully");
                dbconn.Close();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gunaDataGridViewCat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void populate()
        {
            dbconn.Open();
            string query = $"SELECT * FROM `category`";
            //dbconn.Query(query);
            var reader = dbconn.Reader(query);
            //MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
            DataTable table = new DataTable();
            table.Load(reader.ExecuteReader());

            //adapter.Fill(dataSet);
            gunaDataGridViewCat.DataSource = table;
            dbconn.Close();
        }

        private void Category_Load_1(object sender, EventArgs e)
        {
            populate();
        }
    }
}
