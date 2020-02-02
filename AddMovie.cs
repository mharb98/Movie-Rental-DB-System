using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MovieRentalDB
{
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
        }

        private void Add_movie_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=HP;Initial Catalog=MovieRental;Integrated Security=True";
            Random rnd = new Random();
            string ID;
            DataTable dt;
            do
            {
                ID = rnd.Next(10000).ToString();
                string str = "if exists (select * from MOVIE where MOVIE_ID = " + ID + ") select 'Found' as EXIST else select 'Not Found' as EXIST";
                SqlDataAdapter sda = new SqlDataAdapter(str, connection);
                dt = new DataTable();
                sda.Fill(dt);
            } while (dt.Rows[0][0].ToString() == "Found");

            string selectedItem = Quality.SelectedItem.ToString();
            
            string com = "insert into MOVIE values(" + ID + "," + Form4.ID + ",'" + MovieName.Text + "','" + Duration.Text + "','" + Rating.Text + "','" + countryy.Text + "','" + selectedItem + "','" + Director.Text + "','" + MovieDate.Text + "','" + price.Text + "')";

            string categorys = "";
            foreach (Object item in Category.CheckedItems)
            {
                categorys += "Insert Into Mcategory values (" + ID + ", '" + item.ToString() + "') ";   
            }
            
            string actors = "";
            string actor = "";
            foreach (Object item in Actors.Text)
                actors += item.ToString();
            string tp = "";
            Boolean ok = false;
            for(int i=0; i<actors.Length; i++)
            {
                if (ok)
                {
                    ok = false;
                    continue;
                }
                if(actors[i] == ',')
                {
                    actor += "Insert Into Actors values (" + ID + ", '" + tp + "') ";
                    tp = "";
                    ok = true;
                }
                else
                    tp += actors[i];
                if(i == actors.Length-1)
                    actor += "Insert Into Actors values (" + ID + ", '" + tp + "') ";
            }
            connection.Open();
            SqlCommand Command = new SqlCommand(com, connection);
            SqlCommand Command1 = new SqlCommand(categorys, connection);
            SqlCommand Command2 = new SqlCommand(actor, connection);
            Command.ExecuteNonQuery();
            Command1.ExecuteNonQuery();
            Command2.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("DONE");
        }

        private void finish_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
