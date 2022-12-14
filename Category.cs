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
        MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=shoprite;password=");
        private void buttonCatAdd_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = $"INSERT INTO `category`(`catId`, `catName`, `catDescription`) VALUES ('{tbCatId.Text.ToLower()}','{tbCatName.Text.ToLower()}','{tbCatDesc.Text.ToLower()}')";
                MySqlCommand cmmd = new MySqlCommand(query, conn);
                cmmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully");
                
                
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                populate();
            }
        }
        
        private void gunaDataGridViewCat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbCatId.Text = gunaDataGridViewCat.SelectedRows[0].Cells[0].Value.ToString();
            tbCatName.Text = gunaDataGridViewCat.SelectedRows[0].Cells[1].Value.ToString();
            tbCatDesc.Text = gunaDataGridViewCat.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void populate()
        {
            conn.Open();
            string query = $"SELECT * FROM `category`";

            //dbconn.Query(query);
            //var reader = dbconn.Reader(query);
            //MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
            var dataSet = new DataSet();
            //DataTable table = new DataTable();
            //table.Load(reader.ExecuteReader());
            adapter.Fill(dataSet);
            gunaDataGridViewCat.DataSource = dataSet.Tables[0];
            //gunaDataGridViewCat.DataSource = table;
            conn.Close();
        }

        private void Category_Load_1(object sender, EventArgs e)
        {
            populate();
        }

        private void buttonCatDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbCatId.Text == "" || tbCatId.Text == " ")
                    MessageBox.Show("Please Select a Category to Delete");
                else
                {
                    conn.Open();
                    string query = $"DELETE FROM `category` WHERE `catId` = '{tbCatId.Text}'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Sucessfully");
                    conn.Close();
                    populate();
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void buttonCatEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbCatName.Text == "" || tbCatId.Text == "" || tbCatDesc.Text == "")
                    MessageBox.Show("PLease Enter the Missing Information");
                else
                {
                    conn.Open();
                    string query = $"UPDATE `category` SET `catName`='{tbCatName.Text}',`catDescription`='{tbCatDesc.Text}' WHERE `catId`='{tbCatId.Text}'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Updated Sucessfully");
                    conn.Close();
                    populate();
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonProd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Show();
            this.Hide();
        }

        private void buttonCashier_Click(object sender, EventArgs e)
        {
            Cashier cash = new Cashier();
            cash.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin login = new FormLogin();
            login.Show();
        }
    }
}
