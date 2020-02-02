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
    public partial class Form10 : Form
    {
        Form f8;
        public Form10(Form f)
        {
            InitializeComponent();
            f8 = f;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Form4.ID && textBox2.Text == Form4.password)
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=HP;Initial Catalog=MovieRental;Integrated Security=True";
                SqlCommand Command = new SqlCommand("Delete From ADMIN Where ADMIN_ID = '" + textBox1.Text + "'", connection);
                connection.Open();
                Command.ExecuteNonQuery();
                MessageBox.Show("Account Deleted");
                connection.Close();   
                this.Hide();
                f8.Hide();
            }
            else
            {
                MessageBox.Show("Invalid UserName Or Password,Try again");
            }
        }
    }
}
