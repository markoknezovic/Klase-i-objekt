using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlaseObjekti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            try
            {
                Clasa osoba = new Clasa(txtString.Text, Convert.ToInt32(txtInt.Text));
                textBox3.Text = osoba.ToString();
            }
            catch (Exception greska)
            {
                MessageBox.Show("greska");
            }

            }

        private void btnIspisi_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtInt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtString_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
