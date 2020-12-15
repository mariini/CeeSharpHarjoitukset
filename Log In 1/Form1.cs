using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log_In_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKirjaudu_Click(object sender, EventArgs e)
        {
            if(txtKayttaja.Text=="Käyttäjätunnus" && txtSalasana.Text=="Salasana")
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Käyttätunnus ja salasana eivät täsmää. Yritä uudestaan!");
                txtKayttaja.Clear();
                txtSalasana.Clear();
                txtKayttaja.Focus();
            }
        }

        private void lblTyhjenna_Click(object sender, EventArgs e)
        {
            txtKayttaja.Clear();
            txtSalasana.Clear();
            txtKayttaja.Focus();
        }

        private void lblSulje_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}