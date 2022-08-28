using System;
using System.Collections;
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

        MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=shoprite;password=");
        MySqlDataReader reader;

        private void populate()
        {
            conn.Open();
            string query = $"SELECT * FROM `cashier`";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
            var dataSet = new DataSet();
            adapter.Fill(dataSet);
            gunaDataGridViewCash.DataSource = dataSet.Tables[0];
            conn.Close();
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
            string pass;
            string name = "";
            pass = Hash.Hash_SHA1(bunifuMaterialTextboxPass.Text);
            MySqlCommand cmd;
            try
            {
                string qry = $"SELECT `cashName` FROM `cashier` WHERE 1";
                cmd = new MySqlCommand(qry, conn);
                conn.Open();
                reader = cmd.ExecuteReader();
          
                while (reader.Read())
                {
                    name = reader.GetString("cashName");
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
               conn.Close();
                //populate();
            }

            if (name == bunifuMaterialTextboxName.Text)
            {
                MessageBox.Show("Please The Username Already exist!!");

            }
            else
            {
                try
                {
                    conn.Open();
                    string query = $"INSERT INTO `cashier`(`cashName`, `cashDOB`, `cashPhone`, `cashPassword`) VALUES ('{bunifuMaterialTextboxName.Text}','{bunifuMaterialTextboxDOB.Text}','{bunifuMaterialTextboxPhone.Text}', '{pass}')";

                    cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cashier Added Successfully");
                    conn.Close();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                    populate();
                }
                

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
                    string pass = Hash.Hash_SHA1(bunifuMaterialTextboxPass.Text);
                    conn.Open();
                    string query = $"UPDATE `cashier` SET `cashName`='{bunifuMaterialTextboxName.Text}',`cashDOB`='{bunifuMaterialTextboxDOB.Text}', `cashPhone`='{bunifuMaterialTextboxPhone.Text}', `cashPassword`='{pass}' WHERE `cashId`='{bunifuMaterialTextboxID.Text}'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Cashier Detail Updated Sucessfully");

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
            }
            finally
            {
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
                    conn.Close();
                    MessageBox.Show("Cashier Deleted Sucessfully");
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
            }
            finally
            {
                conn.Close();
            }
        }

        private void label6_Click(object sender, EventArgs e)
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
