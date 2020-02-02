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
    public partial class Form6 : Form
    {
        Form f5;
        public Form6(Form f)
        {
            InitializeComponent();
            f5 = f;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==Form3.username && textBox2.Text==Form3.password)
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=HP;Initial Catalog=MovieRental;Integrated Security=True";
                SqlCommand Command = new SqlCommand("Delete From Account Where USERNAME = '" + textBox1.Text + "'", connection);
                connection.Open();
                Command.ExecuteNonQuery();      
                connection.Close();
                MessageBox.Show("Account Deleted");
                this.Hide();
                f5.Hide();
            }
            else
            {
                MessageBox.Show("Invalid UserName Or Password,Try again");
            }
        }
    }
}
