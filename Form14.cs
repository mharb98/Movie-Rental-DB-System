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
    public partial class Form14 : Form
    {
        public string ID = "";
        public string name = "",BDate="",EDate="";
        public double price = 0.0;
        public Boolean ok1 = false;
        public Boolean ok2 = false;
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ok2)
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=HP;Initial Catalog=MovieRental;Integrated Security=True";
                Random rnd = new Random();
                string RentalID;
                DataTable dt;
                do
                {
                    RentalID = rnd.Next(100000).ToString();
                    string str = "if exists (select * from Rental where RENTAL_ID = " + RentalID + ") select 'Found' as EXIST else select 'Not Found' as EXIST";
                    SqlDataAdapter sda = new SqlDataAdapter(str, connection);
                    dt = new DataTable();
                    sda.Fill(dt);
                } while (dt.Rows[0][0].ToString() == "Found");
                string TransID;
                do
                {
                    TransID = rnd.Next(100000).ToString();
                    string str = "if exists (select * from Mtransaction where TransID = " + TransID + ") select 'Found' as EXIST else select 'Not Found' as EXIST";
                    SqlDataAdapter sda = new SqlDataAdapter(str, connection);
                    dt = new DataTable();
                    sda.Fill(dt);
                } while (dt.Rows[0][0].ToString() == "Found");

                string com1 = "insert into RENTAL values(" + RentalID + ",'" + Form3.username + "','" + EDate + "','" + BDate + "','"+ name + "')";
                string com2 = "insert into Mtransaction values(" + RentalID + ", " + TransID + "," + price.ToString() + ")";
                connection.Open();
                SqlCommand command1 = new SqlCommand(com1, connection);
                SqlCommand command2 = new SqlCommand(com2, connection);

                command1.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                connection.Close();
                output.AppendText("Done\n");
                output.AppendText("Trascation ID: " + TransID + "\n");
                output.AppendText("Rental ID: " + RentalID + "\n");
                ok1 = false;
                ok2 = false;
                name = "";
                ID = "";
                BDate = "";
                EDate = "";
                price = 0.0;
            }
            else
                MessageBox.Show("invaled");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void search_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=HP;Initial Catalog=MovieRental;Integrated Security=True";
            string str = "if exists (select * from MOVIE where MOVIE_ID = " + MovieID.Text + " and MOVIE_NAME = '" + MovieName.Text + "') select 'Found' as EXIST else select 'Not Found' as EXIST";
            SqlDataAdapter sda = new SqlDataAdapter(str, connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "Found")
            {
                ID = MovieID.Text;
                name = MovieName.Text;
                output.AppendText("Movie Name: " + name +"\n");
                ok1 = true;
            }
            else
                MessageBox.Show("NO Data with this Name and ID");
        }

        private void GetPrice_Click(object sender, EventArgs e)
        {
            if (ok1)
            {
                BDate = BeginDate.Text;
                EDate = EndDate.Text;
                output.AppendText("Begin Date: " + BeginDate.Text + "\n");
                output.AppendText("End Date: " + EndDate.Text + "\n");
                string d1 = "", d2 = "";
                for (int i = 0; i < BDate.Length; i++)
                {
                    if (BDate[i] == '/')
                        break;
                    d1 += BDate[i];
                }
                for (int i = 0; i < EDate.Length; i++)
                {
                    if (EDate[i] == '/')
                        break;
                    d2 += EDate[i];
                }
                int t1 = Convert.ToInt32(d1);
                int t2 = Convert.ToInt32(d2);
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=HP;Initial Catalog=MovieRental;Integrated Security=True";
                string str = "select Price from MOVIE where MOVIE_ID = " + ID + " and MOVIE_NAME = '" + name + "'";
                SqlDataAdapter sda = new SqlDataAdapter(str, connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string tp = dt.Rows[0][0].ToString();
                price = Math.Abs(t2 - t1) * 1.22224 * Convert.ToDouble(tp);
                output.AppendText("Total Rental Price: " + price.ToString() + "\n");
                ok2 = true;
            }
            else
                MessageBox.Show("Invaled");
        }
    }
}
