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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=HP;Initial Catalog=MovieRental;Integrated Security=True";

            string str = "if exists (select UserName from PaymentInformation where USERNAME = '" + Form3.username + "') select 'Found' as EXIST else select 'Not Found' as EXIST";
            SqlDataAdapter sda = new SqlDataAdapter(str, connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "Found")
            {
                SqlCommand Command = new SqlCommand("update PaymentInformation set CVV = '" + textBox1.Text + "' where UserName = '" + Form3.username + "'", connection);
                SqlCommand command2 = new SqlCommand("update PaymentInformation set CardNumber = '" + textBox2.Text + "' where UserName = '" + Form3.username + "'", connection);
                SqlCommand command3 = new SqlCommand("update PaymentInformation set ExpirationDate = '" + dateTimePicker1.Value.ToString() + "' where UserName = '" + Form3.username + "'", connection);

                connection.Open();
                Command.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                command3.ExecuteNonQuery();
                MessageBox.Show("Payment Info Changed");
                connection.Close();
                this.Hide();
            }
            else
                MessageBox.Show("No Information Exists");
                
        }
    }
}
