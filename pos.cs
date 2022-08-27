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
    public partial class POS : Form
    {
        public POS()
        {
            InitializeComponent();
        }

        MySqlConnection conn = new MySqlConnection(DBconn.Connection());
        string query = "";
        MySqlCommand cmd;
        MySqlDataReader reader;

        private void populate()
        {
            conn.Open();
            string query = $"SELECT `barcode`, `name`, `quantity`, `price` FROM `product`";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
            var dataSet = new DataSet();
            adapter.Fill(dataSet);
            gunaDataGridViewProd.DataSource = dataSet.Tables[0];
            conn.Close();
        }

        private void labelManageCategories_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void POS_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            labelDate.Text = DateTime.Today.Year.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Day.ToString();
        }

        // Radom String Generator

        private void buttonCatAdd_Click(object sender, EventArgs e)
        {
            Decimal subTotal = Decimal.Parse(tbPrice.Text) * Decimal.Parse(tbQty.Text), overallTotal = 0;


            if (tbProdName.Text == "" || tbBarcode.Text == "" || tbPrice.Text=="" || tbQty.Text == "" )
            {
                MessageBox.Show("Please ensure to enter all details");
            }
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(gunaDataGridViewOrder);
            row.Cells[0].Value = tbBarcode.Text;
            row.Cells[1].Value = tbProdName.Text;
            row.Cells[2].Value = tbQty.Text;
            row.Cells[3].Value = tbPrice.Text;//Convert.ToInt32(tbPrice.Text) * Convert.ToInt32(tbQty.Text);
            row.Cells[4].Value = subTotal;

            gunaDataGridViewOrder.Rows.Add(row);
            //overallTotal += subTotal;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (labelBarcode.Text == "" || labelBarcode.Text == " " )
            {
                MessageBox.Show("Please Enter a valid Barcode");
            } else
            {
                try
                {
                    query = $"SELECT * FROM `product` WHERE `barcode` = '{tbBarcode.Text}'";
                    conn.Open();
                    cmd = new MySqlCommand(query, conn);
                    reader = cmd.ExecuteReader();
                    string[] rw = new string[] {};

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string[] row = {reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4)};
                            rw = row;
                        }
                        
                        conn.Close();
                    }else
                    {
                        MessageBox.Show("Sorry no such product exists");
                        conn.Close();
                    }
                    tbBarcode.Text = rw[0];
                    tbProdName.Text = rw[1];
                    tbQty.Text = rw[2];
                    tbPrice.Text = rw[3];
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
            }
        }

        private void gunaDataGridViewProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbBarcode.Text = gunaDataGridViewProd.SelectedRows[0].Cells[0].Value.ToString();
            tbProdName.Text = gunaDataGridViewProd.SelectedRows[0].Cells[1].Value.ToString();
            //tbQty.Text = gunaDataGridViewProd.SelectedRows[0].Cells[2].Value.ToString();
            tbPrice.Text = gunaDataGridViewProd.SelectedRows[0].Cells[3].Value.ToString();
            //comboBoxCatRole.SelectedValue = gunaDataGridViewProd.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
