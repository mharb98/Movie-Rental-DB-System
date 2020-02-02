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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=HP;Initial Catalog=MovieRental;Integrated Security=True";
            DataTable tempdt = new DataTable();
            string stry = "if exists (select * from ACCOUNT where USERNAME = '" + UserName.Text + "') select 'Found' as EXIST else select 'Not Found' as EXIST";
            SqlDataAdapter tempsda = new SqlDataAdapter(stry, connection);
            tempsda.Fill(tempdt);

            if (Password.Text != ConfirmPass.Text && tempdt.Rows[0][0].ToString() == "Found")
                MessageBox.Show("Username Already Exists\nPassword is Not Confirm Password");
            else if (Password.Text != ConfirmPass.Text)
                MessageBox.Show("Password is Not Confirm Password");
            else if (tempdt.Rows[0][0].ToString() == "Found")  
                MessageBox.Show("Username Already Exists");
            else
            {
                string str = "Insert Into Account values ( '" + UserName.Text + "','" + Password.Text + "','" + FirstName.Text + "','" + LastName.Text + "','" + EMail.Text + "','" + PhoneNum.Text + "','" + Country.Text + "')";
                SqlCommand Command = new SqlCommand(str, connection);
                connection.Open();
                Command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("New User Has Been Created Succesfully");
                this.Hide();
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }
        }
    }
}