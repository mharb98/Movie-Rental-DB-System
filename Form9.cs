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
    public partial class Form9 : Form
    {
       
        public Form9()
        {
            InitializeComponent();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Form4.ID && textBox2.Text == Form4.password)
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=HP;Initial Catalog=MovieRental;Integrated Security=True";
                SqlCommand Command = new SqlCommand("update ADMIN set ADMIN_NAME = '" + textBox3.Text + "' where ADMIN_ID = '" + textBox1.Text + "'", connection);

                connection.Open();
                MessageBox.Show("Name Changed");
                Command.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username and Password,Try again");

            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Form4.ID && textBox2.Text == Form4.password)
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=HP;Initial Catalog=MovieRental;Integrated Security=True";
                SqlCommand Command = new SqlCommand("update ADMIN set E-mail = '" + textBox4.Text + "' where ADMIN_ID = '" + textBox1.Text + "'", connection);

                connection.Open();
                MessageBox.Show("E-mail Updated");
                Command.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username and Password,Try again");

            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Form4.ID && textBox2.Text == Form4.password)
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=HP;Initial Catalog=MovieRental;Integrated Security=True";
                SqlCommand Command = new SqlCommand("update ADMIN set Password = '" + textBox5.Text + "' where ADMIN_ID = '" + textBox1.Text + "'", connection);

                connection.Open();
                MessageBox.Show("Password Changed");
                Command.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username and Password,Try again");

            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Form4.ID && textBox2.Text == Form4.password)
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=HP;Initial Catalog=MovieRental;Integrated Security=True";
                SqlCommand Command = new SqlCommand("update ADMIN set A_COUNTRY = '" + textBox6.Text + "' where ADMIN_ID = '" + textBox1.Text + "'", connection);

                connection.Open();
                MessageBox.Show("Country Changed");
                Command.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username and Password,Try again");

            }
        }
    }
}
