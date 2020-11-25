using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button_start_game_Click(object sender, EventArgs e)
        {
            // No longer needed, form 2 not in use

            // Form1.annaNimet(ekaPelaaja.Text, tokaPelaaja.Text);
            this.Close();
        }

        private void tokaPelaaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
                button_start_game.PerformClick();
        }
    }

}
