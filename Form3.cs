using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRentalDB
{
    public partial class Form3 : Form
    {
        public static string username;
        public static string password;
        public Form3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("You must fill the boxs");
            }
            else
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=HP;Initial Catalog=MovieRental;Integrated Security=True";
                string str = "if exists (select * from ACCOUNT where USERNAME = '" + textBox1.Text + "' and Apassword = '" + textBox2.Text + "') select 'Found' as EXIST else select 'Not Found' as EXIST";
                SqlDataAdapter sda = new SqlDataAdapter(str, connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "Found")
                {
                    MessageBox.Show("UserName and Password found");
                    username = textBox1.Text;
                    password = textBox2.Text;
                    Form5 f5 = new Form5();
                    this.Hide();
                    f5.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid UserName Or Password");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
