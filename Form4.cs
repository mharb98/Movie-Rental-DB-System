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
    public partial class Form4 : Form
    {
        public static string ID;
        public static string password;
        public Form4()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("You must fill the boxs");
            }
            else
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=HP;Initial Catalog=MovieRental;Integrated Security=True";
                string str = "if exists (select * from ADMIN where ADMIN_ID = " + textBox1.Text + " and Password = '" + textBox2.Text + "') select 'Found' as EXIST else select 'Not Found' as EXIST";
                SqlDataAdapter sda = new SqlDataAdapter(str, connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "Found")
                {
                    MessageBox.Show("UserName and Password found");
                    ID = textBox1.Text;
                    password = textBox2.Text;
                    Form8 f8 = new Form8();
                    this.Hide();
                    f8.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid UserName Or Password");
                }
            }
        }
    }
}
