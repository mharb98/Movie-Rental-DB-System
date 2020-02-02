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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=HP;Initial Catalog=MovieRental;Integrated Security=True";
            string str = "select T.RENTAL_ID,T.TransID,T.MName,T.BEGIN_DATE,T.END_DATE from(select R.RENTAL_ID, R.USERNAME, R.MName, R.BEGIN_DATE, R.END_DATE, M.TransID from RENTAL R inner join Mtransaction M on R.RENTAL_ID = M.RentalID) as T where T.USERNAME = '" + Form3.username + "'";
            SqlDataAdapter sda = new SqlDataAdapter(str, connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                String[] tp = new string[5];
                int i = 0;
                foreach (DataColumn col in dt.Columns)
                {
                    tp[i] = row[col].ToString();
                    i++;
                }
                output.AppendText("Rental ID: " + tp[0] + ", Transaction ID: " + tp[1] + ", Movie Name: " + tp[2] + ", Begin Date: " + tp[3] + ", End Date: " + tp[4]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=HP;Initial Catalog=MovieRental;Integrated Security=True";
            string str = "update RENTAL set END_DATE = '"+newdate.Text+"' where RENTAL_ID = " + RID.Text;
            connection.Open();
            SqlCommand command = new SqlCommand(str, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
