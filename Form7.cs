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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            this.Hide();          
        }

        private void Button1_Click(object sender, EventArgs e)
        { 
            if (textBox8.Text==Form3.username && textBox9.Text==Form3.password)
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=HP;Initial Catalog=MovieRental;Integrated Security=True";
                SqlCommand Command = new SqlCommand("update Account set EMail = '" + textBox1.Text + "' where USERNAME = '" + textBox8.Text + "'", connection);

                connection.Open();
                MessageBox.Show("Update E-mail");
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
            if (textBox8.Text == Form3.username && textBox9.Text == Form3.password)
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=HP;Initial Catalog=MovieRental;Integrated Security=True";
                SqlCommand Command = new SqlCommand("update Account set FirstName = '" + textBox1.Text + "' where USERNAME = '" + textBox8.Text + "'", connection);

                connection.Open();
                MessageBox.Show("Update First Name");
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
            if (textBox8.Text == Form3.username && textBox9.Text == Form3.password)
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=HP;Initial Catalog=MovieRental;Integrated Security=True";
                SqlCommand Command = new SqlCommand("update Account set LastName = '" + textBox1.Text + "' where USERNAME = '" + textBox8.Text + "'", connection);

                connection.Open();
                MessageBox.Show("Update Last Name");
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
            if (textBox8.Text == Form3.username && textBox9.Text == Form3.password)
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=HP;Initial Catalog=MovieRental;Integrated Security=True";
                SqlCommand Command = new SqlCommand("update Account set Apassword = '" + textBox1.Text + "' where USERNAME = '" + textBox8.Text + "'", connection);

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

        private void Button5_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == Form3.username && textBox9.Text == Form3.password)
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=HP;Initial Catalog=MovieRental;Integrated Security=True";
                SqlCommand Command = new SqlCommand("update Account set PhoneNum = '" + textBox1.Text + "' where USERNAME = '" + textBox8.Text + "'", connection);

                connection.Open();
                MessageBox.Show("Update Phone Number");
                Command.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username and Password,Try again");

            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == Form3.username && textBox9.Text == Form3.password)
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=HP;Initial Catalog=MovieRental;Integrated Security=True";
                SqlCommand Command = new SqlCommand("update Account set Country = '" + textBox1.Text + "' where USERNAME = '" + textBox8.Text + "'", connection);

                connection.Open();
                MessageBox.Show("Changed Country");
                Command.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username and Password,Try again");

            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == Form3.username && textBox9.Text == Form3.password)
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=HP;Initial Catalog=MovieRental;Integrated Security=True";
                SqlCommand Command = new SqlCommand("update Account set FAV_CCATEGORY = '" + textBox1.Text + "' where USERNAME = '" + textBox8.Text + "'", connection);

                connection.Open();
                MessageBox.Show("Favorite Category Made");
                Command.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username and Password,Try again");

            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == Form3.username && textBox9.Text == Form3.password)
            {
                Form11 f11 = new Form11();
                f11.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Username and Password,try again");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.ShowDialog();
        }
    }
}
