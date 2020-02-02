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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectedItem = Category.SelectedItem.ToString();
            string str = "if exists (select* from FavCategory where USERNAME = '" + Form3.username + "' and FCategory = '" + selectedItem + "') select 'Found' as EXIST else select 'Not Found' as EXIST";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=HP;Initial Catalog=MovieRental;Integrated Security=True";
            SqlDataAdapter sda = new SqlDataAdapter(str, connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "Found")
                MessageBox.Show("Already Added");
            else
            {
                string com = "insert into FavCategory values('" + Form3.username + "','" + selectedItem + "')";
                SqlCommand Command = new SqlCommand(com, connection);
                connection.Open();
                Command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Added Succesfully");
            }
        }
    }
}
