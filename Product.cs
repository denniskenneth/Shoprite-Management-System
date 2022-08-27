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

        private void populate()
        {
            conn.Open();
            string query = $"SELECT * FROM `product`";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
            var dataSet = new DataSet();
            adapter.Fill(dataSet);
            gunaDataGridViewProd.DataSource = dataSet.Tables[0];
            conn.Close();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            fillDropdown();
            populate();
        }

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Show();

            this.Hide();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = $"INSERT INTO `product`(`barcode`, `name`, `quantity`, `price`, `category`) VALUES ('{bunifuMaterialTextboxBarcode.Text}','{bunifuMaterialTextboxName.Text}','{bunifuMaterialTextboxQty.Text}', '{bunifuMaterialTextboxPrice.Text}', '{comboBoxCatRole.SelectedValue.ToString()}')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully");
                conn.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gunaDataGridViewProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bunifuMaterialTextboxBarcode.Text = gunaDataGridViewProd.SelectedRows[0].Cells[0].Value.ToString();
            bunifuMaterialTextboxName.Text = gunaDataGridViewProd.SelectedRows[0].Cells[1].Value.ToString();
            bunifuMaterialTextboxQty.Text = gunaDataGridViewProd.SelectedRows[0].Cells[2].Value.ToString();
            bunifuMaterialTextboxPrice.Text = gunaDataGridViewProd.SelectedRows[0].Cells[3].Value.ToString();
            comboBoxCatRole.SelectedValue = gunaDataGridViewProd.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (bunifuMaterialTextboxName.Text == "" || bunifuMaterialTextboxPrice.Text == "" || bunifuMaterialTextboxQty.Text == "")
                    MessageBox.Show("PLease Enter the Missing Information");
                else
                {
                    conn.Open();
                    string query = $"UPDATE `product` SET `name`='{bunifuMaterialTextboxName.Text}',`quantity`='{bunifuMaterialTextboxQty.Text}', `price`='{bunifuMaterialTextboxPrice.Text}' WHERE `barcode`='{bunifuMaterialTextboxBarcode.Text}'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Updated Sucessfully");
                    conn.Close();
                    populate();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (bunifuMaterialTextboxBarcode.Text == "" || bunifuMaterialTextboxBarcode.Text == " ")
                    MessageBox.Show("Please Select a Product to Delete");
                else
                {
                    conn.Open();
                    string query = $"DELETE FROM `product` WHERE `barcode` = '{bunifuMaterialTextboxBarcode.Text}'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Sucessfully");
                    conn.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCashier_Click(object sender, EventArgs e)
        {
            Cashier cashier = new Cashier();
            cashier.Show();

            this.Hide();
        }

        private void buttonProd_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
