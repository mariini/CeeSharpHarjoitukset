using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Double results = 0;
        String operation = "";
        bool enter_value = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void laskinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 300;
            txtNaytto.Width = 260;
        }

        private void funktiolaskinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 590;
            txtNaytto.Width = 545;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 300;
            txtNaytto.Width = 260;
        }

        //toiminnallisuus numeroille ja pilkulle
        private void button_Click(object sender, EventArgs e)
        {
            if ((txtNaytto.Text == "0") || (enter_value))
                    txtNaytto.Text = "";
            enter_value = false;
            
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!txtNaytto.Text.Contains("."))
                    txtNaytto.Text = txtNaytto.Text + num.Text;
            }
            else
                txtNaytto.Text = txtNaytto.Text + num.Text;
        }
        //tyhjentää viimeisimmän syötetyn luvun tulosnäytöltä
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (txtNaytto.Text.Length > 0)
            {
                txtNaytto.Text = txtNaytto.Text.Remove(txtNaytto.Text.Length - 1, 1);
            }
            if (txtNaytto.Text=="")
            {
                txtNaytto.Text = "0";
            }
            
        }
        //Tyhjentää tulosnäytön kokonaan
        private void btnEmpty_Click(object sender, EventArgs e)
        {
            txtNaytto.Text = "0";
            lblShowOp.Text = "";
        }
        //matemaattinen operaattori laskutoimituksille 
        private void Arithmetic_Operator(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = Double.Parse(txtNaytto.Text);
            txtNaytto.Text = "";
            lblShowOp.Text = System.Convert.ToString(results) + " " + operation;
         }
        // tulosnäppäimen toiminnallisuus
        private void btnTulos_Click(object sender, EventArgs e)
        {
            lblShowOp.Text = "";
            switch(operation)
            {

                case "+":
                    txtNaytto.Text = (results + Double.Parse(txtNaytto.Text)).ToString();
                    break;
                case "-":
                    txtNaytto.Text = (results - Double.Parse(txtNaytto.Text)).ToString();
                    break;
                case "*":
                    txtNaytto.Text = (results * Double.Parse(txtNaytto.Text)).ToString();
                    break;
                case "/":
                    txtNaytto.Text = (results / Double.Parse(txtNaytto.Text)).ToString();
                    break;
                case "Mod":
                    txtNaytto.Text = (results % Double.Parse(txtNaytto.Text)).ToString();
                    break;
                case "Exp":
                    txtNaytto.Text = Math.Pow(results, Double.Parse(txtNaytto.Text)).ToString();
                    break;
            }
        }
        // Piin arvo
        private void btnPii_Click(object sender, EventArgs e)
        {
            txtNaytto.Text = Math.PI.ToString();
        }
        // logaritmin laskutoimitus
        private void btnLogaritmi_Click(object sender, EventArgs e)
        {
            double logaritmi = Double.Parse(txtNaytto.Text);
            lblShowOp.Text = System.Convert.ToString("log" + "(" + Double.Parse(txtNaytto.Text) + ")");
            logaritmi = Math.Log10(logaritmi);
            txtNaytto.Text = System.Convert.ToString(logaritmi);
            
        }
        // neliöjuuren laskutoimitus
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double neliojuuri = Double.Parse(txtNaytto.Text);
            lblShowOp.Text = System.Convert.ToString("sqrt" + "(" + Double.Parse(txtNaytto.Text) + ")");
            neliojuuri = Math.Sqrt(neliojuuri);
            txtNaytto.Text = System.Convert.ToString(neliojuuri);
        }
        // hyperbolinen sini
        private void btnSinh_Click(object sender, EventArgs e)
        {
            double hypersini = Double.Parse(txtNaytto.Text);
            lblShowOp.Text = System.Convert.ToString("sinh" + "(" + Double.Parse(txtNaytto.Text) + ")");
            hypersini = Math.Sinh(hypersini);
            txtNaytto.Text = System.Convert.ToString(hypersini);
        }
        // sini
        private void btnSini_Click(object sender, EventArgs e)
        {
            double sini = Double.Parse(txtNaytto.Text);
            lblShowOp.Text = System.Convert.ToString("sin" + "(" + Double.Parse(txtNaytto.Text) + ")");
            sini = Math.Sin(sini);
            txtNaytto.Text = System.Convert.ToString(sini);
        }
        // hyperbolinen kosini
        private void btnCosh_Click(object sender, EventArgs e)
        {
            double hyperkosini = Double.Parse(txtNaytto.Text);
            lblShowOp.Text = System.Convert.ToString("cosh" + "(" + Double.Parse(txtNaytto.Text) + ")");
            hyperkosini = Math.Cosh(hyperkosini);
            txtNaytto.Text = System.Convert.ToString(hyperkosini);
        }
        // kosini
        private void btnKosini_Click(object sender, EventArgs e)
        {
            double kosini = Double.Parse(txtNaytto.Text);
            lblShowOp.Text = System.Convert.ToString("cos" + "(" + Double.Parse(txtNaytto.Text) + ")");
            kosini = Math.Cos(kosini);
            txtNaytto.Text = System.Convert.ToString(kosini);
        }
        // hyperbolinen tangentti
        private void btnTanh_Click(object sender, EventArgs e)
        {
            double hyperTangentti = Double.Parse(txtNaytto.Text);
            lblShowOp.Text = System.Convert.ToString("tanh" + "(" + Double.Parse(txtNaytto.Text) + ")");
            hyperTangentti = Math.Tanh(hyperTangentti);
            txtNaytto.Text = System.Convert.ToString(hyperTangentti);
        }
        // tangentti
        private void btnTangentti_Click(object sender, EventArgs e)
        {
            double tangentti = Double.Parse(txtNaytto.Text);
            lblShowOp.Text = System.Convert.ToString("tan" + "(" + Double.Parse(txtNaytto.Text) + ")");
            tangentti = Math.Tan(tangentti);
            txtNaytto.Text = System.Convert.ToString(tangentti);
        }
        // annetun luvun binääriluku
        private void btnBinaari_Click(object sender, EventArgs e)
        {
            int luku = int.Parse(txtNaytto.Text);
            txtNaytto.Text = System.Convert.ToString(luku, 2);
        }
        // heksadesimaali
        private void btnHexadesi_Click(object sender, EventArgs e)
        {
            int luku = int.Parse(txtNaytto.Text);
            txtNaytto.Text = System.Convert.ToString(luku, 16);
        }
        // oktaaliluku
        private void btnOktaali_Click(object sender, EventArgs e)
        {
            int luku = int.Parse(txtNaytto.Text);
            txtNaytto.Text = System.Convert.ToString(luku, 8);
        }
        // kymmenkantainen desimaaliluku
        private void btnDesimaali_Click(object sender, EventArgs e)
        {
            int luku = int.Parse(txtNaytto.Text);
            txtNaytto.Text = System.Convert.ToString(luku);
        }
        // luvun toinen potenssi
        private void btnNelio_Click(object sender, EventArgs e)
        {
            Double kanta;
            lblShowOp.Text = System.Convert.ToString("x^2" + "(" + Double.Parse(txtNaytto.Text) + ")");
            kanta = Convert.ToDouble(txtNaytto.Text) * Convert.ToDouble(txtNaytto.Text);
            txtNaytto.Text = System.Convert.ToString(kanta);
        }
        // luvun kolmas potenssi 
        private void btnKuutio_Click(object sender, EventArgs e)
        {
            Double kanta;
            lblShowOp.Text = System.Convert.ToString("x^3" + "(" + Double.Parse(txtNaytto.Text) + ")");
            kanta = Convert.ToDouble(txtNaytto.Text) * Convert.ToDouble(txtNaytto.Text) * Convert.ToDouble(txtNaytto.Text);
            txtNaytto.Text = System.Convert.ToString(kanta);
        }
        //luvun 1 desimaali
        private void btnMurtoluku_Click(object sender, EventArgs e)
        {
            Double kanta;
            lblShowOp.Text = System.Convert.ToString("1/x" + "(" + Double.Parse(txtNaytto.Text) + ")");
            kanta = Convert.ToDouble(1.0 / Convert.ToDouble(txtNaytto.Text));
            txtNaytto.Text = System.Convert.ToString(kanta);
        }
        // luonnollinen logaritmi
        private void btnLnx_Click(object sender, EventArgs e)
        {
            double luonnollinenLogaritmi = Double.Parse(txtNaytto.Text);
            lblShowOp.Text = System.Convert.ToString("nl" + "(" + Double.Parse(txtNaytto.Text) + ")");
            luonnollinenLogaritmi = Math.Log(luonnollinenLogaritmi);
            txtNaytto.Text = System.Convert.ToString(luonnollinenLogaritmi);
        }
        // prosenttiluku > desimaali
        private void btnProsentti_Click(object sender, EventArgs e)
        {
            Double kanta;
            lblShowOp.Text = System.Convert.ToString("(" + Double.Parse(txtNaytto.Text) + "%" + ")");
            kanta = Convert.ToDouble(txtNaytto.Text) / Convert.ToDouble(100);
            txtNaytto.Text = System.Convert.ToString(kanta);
            
        }

        private void btnNegaPosi_Click(object sender, EventArgs e)
        {
            Double kanta;
            kanta = Convert.ToDouble(txtNaytto.Text) * (-1);
            txtNaytto.Text = System.Convert.ToString(kanta);
        }
    }
}
