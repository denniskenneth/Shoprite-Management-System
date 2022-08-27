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
using Shoprite_Management_System.Database;

namespace Shoprite_Management_System
{
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
        }

        MySqlConnection conn = new MySqlConnection(DBconn.Connection());

        private void populate()
        {
            conn.Open();
            string query = $"SELECT * FROM `cashier`";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
            var dataSet = new DataSet();
            adapter.Fill(dataSet);
            gunaDataGridViewCash.DataSource = dataSet.Tables[0];
        }

        private void buttonProd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Show();

            this.Hide();
        }

        private void buttonCat_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Show();

            this.Hide();
        }

        private void Cashier_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = $"INSERT INTO `cashier`(`cashName`, `cashDOB`, `cashPhone`, `cashPassword`) VALUES ('{bunifuMaterialTextboxName.Text}','{bunifuMaterialTextboxDOB.Text}','{bunifuMaterialTextboxPhone.Text}', '{bunifuMaterialTextboxPass.Text}')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cashier Added Successfully");
                conn.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void gunaDataGridViewCash_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bunifuMaterialTextboxID.Text = gunaDataGridViewCash.SelectedRows[0].Cells[0].Value.ToString();
            bunifuMaterialTextboxName.Text = gunaDataGridViewCash.SelectedRows[0].Cells[1].Value.ToString();
            bunifuMaterialTextboxDOB.Text = gunaDataGridViewCash.SelectedRows[0].Cells[2].Value.ToString();
            bunifuMaterialTextboxPhone.Text = gunaDataGridViewCash.SelectedRows[0].Cells[3].Value.ToString();
           // bunifuMaterialTextboxPass.Text = gunaDataGridViewCash.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (bunifuMaterialTextboxName.Text == "" || bunifuMaterialTextboxID.Text == "" || bunifuMaterialTextboxDOB.Text == "" || bunifuMaterialTextboxPass.Text == "")
                    MessageBox.Show("PLease Enter the Missing Information");
                else
                {
                    conn.Open();
                    string query = $"UPDATE `cashier` SET `cashName`='{bunifuMaterialTextboxName.Text}',`cashDOB``='{bunifuMaterialTextboxDOB.Text}', `cashPhone`='{bunifuMaterialTextboxPhone.Text}', `cashPassword`='{bunifuMaterialTextboxPass.Text}' WHERE `cashId`='{bunifuMaterialTextboxID.Text}'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cashier Detail Updated Sucessfully");
                    conn.Close();
                    populate();
                    bunifuMaterialTextboxID.Text = "";
                    bunifuMaterialTextboxName.Text = "";
                    bunifuMaterialTextboxPhone.Text = "";
                    bunifuMaterialTextboxDOB.Text = "";
                    bunifuMaterialTextboxPass.Text = "";
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (bunifuMaterialTextboxID.Text == "" || bunifuMaterialTextboxID.Text == " ")
                    MessageBox.Show("Please Select a Cashier to Delete");
                else
                {
                    conn.Open();
                    string query = $"DELETE FROM `cashier` WHERE `cashId` = '{bunifuMaterialTextboxID.Text}'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cashier Deleted Sucessfully");
                    conn.Close();
                    populate();
                    bunifuMaterialTextboxID.Text = "";
                    bunifuMaterialTextboxName.Text = "";
                    bunifuMaterialTextboxPhone.Text = "";
                    bunifuMaterialTextboxDOB.Text = "";
                    bunifuMaterialTextboxPass.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close ();  
            }
        }
    }
}
