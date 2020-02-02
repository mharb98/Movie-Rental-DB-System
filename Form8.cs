using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRentalDB
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10(this);
            f10.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AddMovie addMovie = new AddMovie();
            addMovie.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateMovie updaty = new UpdateMovie();
            updaty.ShowDialog();
        }
    }
}
