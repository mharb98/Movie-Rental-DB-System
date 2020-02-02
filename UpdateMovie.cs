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
    public partial class UpdateMovie : Form
    {
        public Boolean action = false;
        public string ID = "";
        public UpdateMovie()
        {
            InitializeComponent();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (action)
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=HP;Initial Catalog=MovieRental;Integrated Security=True";
                SqlCommand Command = new SqlCommand("update MOVIE set MOVIE_NAME = '" + MovieName.Text + "' where MOVIE_ID = " + ID, connection);
                connection.Open();
                Command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Movie Name Updated");
            }
            else
                MessageBox.Show("Please Enter A Search Name First");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (action)
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=HP;Initial Catalog=MovieRental;Integrated Security=True";
                SqlCommand Command = new SqlCommand("update MOVIE set RELEASE_YEAR = '" + MovieDate.Text + "' where MOVIE_ID = " + ID, connection);
                connection.Open();
                Command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Movie Date Updated");
            }
            else
                MessageBox.Show("Please Enter A Search Name First");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (action)
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=HP;Initial Catalog=MovieRental;Integrated Security=True";
                string categorys = "";
                string com1 = "delete from Mcategory where MovieID = "+ID;
                foreach (Object item in Category.CheckedItems)
                {
                    categorys += "Insert Into Mcategory values (" + ID + ", '" + item.ToString() + "') ";
                }
                SqlCommand Command1 = new SqlCommand(com1, connection);
                SqlCommand Command2 = new SqlCommand(categorys, connection);
                connection.Open();
                Command1.ExecuteNonQuery();
                Command2.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Movie Category Updated");
            }
            else
                MessageBox.Show("Please Enter A Search Name First");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (action)
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=HP;Initial Catalog=MovieRental;Integrated Security=True";
                SqlCommand Command = new SqlCommand("update MOVIE set DURATION = '" + Duration.Text + "' where MOVIE_ID = " + ID, connection);
                connection.Open();
                Command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Movie Duration Updated");
            }
            else
                MessageBox.Show("Please Enter A Search Name First");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (action)
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=HP;Initial Catalog=MovieRental;Integrated Security=True";
                SqlCommand Command = new SqlCommand("update MOVIE set RATING = '" + Rating.Text + "' where MOVIE_ID = " + ID, connection);
                connection.Open();
                Command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Movie Rating Updated");
            }
            else
                MessageBox.Show("Please Enter A Search Name First");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (action)
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=HP;Initial Catalog=MovieRental;Integrated Security=True";
                SqlCommand Command = new SqlCommand("update MOVIE set DIRECTOR = '" + Director.Text + "' where MOVIE_ID = " + ID, connection);
                connection.Open();
                Command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Movie Director Updated");
            }
            else
                MessageBox.Show("Please Enter A Search Name First");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (action)
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=HP;Initial Catalog=MovieRental;Integrated Security=True";
                string selectedItem = Quality.SelectedItem.ToString();
                SqlCommand Command = new SqlCommand("update MOVIE set QUALITY = '" + selectedItem + "' where MOVIE_ID = " + ID, connection);
                connection.Open();
                Command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Movie Quality Updated");
            }
            else
                MessageBox.Show("Please Enter A Search Name First");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (action)
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=HP;Initial Catalog=MovieRental;Integrated Security=True";
                SqlCommand Command = new SqlCommand("update MOVIE set M_COUNTRY = '" + countryy.Text + "' where MOVIE_ID = " + ID, connection);
                connection.Open();
                Command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Movie Country Updated");
            }
            else
                MessageBox.Show("Please Enter A Search Name First");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (action)
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=HP;Initial Catalog=MovieRental;Integrated Security=True";
                string com1 = "delete from Actors where MovieID = " + ID;
                string actors = "";
                string actor = "";
                foreach (Object item in Actors.Text)
                    actors += item.ToString();
                string tp = "";
                Boolean ok = false;
                for (int i = 0; i < actors.Length; i++)
                {
                    if (ok)
                    {
                        ok = false;
                        continue;
                    }
                    if (actors[i] == ',')
                    {
                        actor += "Insert Into Actors values (" + ID + ", '" + tp + "') ";
                        tp = "";
                        ok = true;
                    }
                    else
                        tp += actors[i];
                    if (i == actors.Length - 1)
                        actor += "Insert Into Actors values (" + ID + ", '" + tp + "') ";
                }
                SqlCommand Command1 = new SqlCommand(com1, connection);
                SqlCommand Command2 = new SqlCommand(actor, connection);
                connection.Open();
                Command1.ExecuteNonQuery();
                Command2.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Movie Actors Updated");
            }
            else
                MessageBox.Show("Please Enter A Search Name First");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (action)
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=HP;Initial Catalog=MovieRental;Integrated Security=True";
                SqlCommand Command = new SqlCommand("update MOVIE set MOVIE_NAME = '" + MovieName.Text + "' where MOVIE_ID = " + ID, connection);
                connection.Open();
                Command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Movie Name Updated");
            }
            else
                MessageBox.Show("Please Enter A Search Name First");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=HP;Initial Catalog=MovieRental;Integrated Security=True";
            string str = "if exists (select * from MOVIE where MOVIE_NAME = '" + Search.Text + "') select 'Found' as EXIST else select 'Not Found' as EXIST";
            SqlDataAdapter sda = new SqlDataAdapter(str, connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "Found")
            {
                string com1 = "select MOVIE_ID from MOVIE where MOVIE_NAME = '"+Search.Text+"'";
                SqlDataAdapter sdaa = new SqlDataAdapter(com1, connection);
                DataTable dtt = new DataTable();
                sdaa.Fill(dtt);
                ID = dtt.Rows[0][0].ToString();
                MessageBox.Show("FOUND");
                action = true;
            }
            else
                action = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (action)
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=HP;Initial Catalog=MovieRental;Integrated Security=True";
                SqlCommand Command = new SqlCommand("update MOVIE set Price = '" + price.Text + "' where MOVIE_ID = " + ID, connection);
                connection.Open();
                Command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Movie Price Updated");
            }
            else
                MessageBox.Show("Please Enter A Search Name First");
        }
    }
}
