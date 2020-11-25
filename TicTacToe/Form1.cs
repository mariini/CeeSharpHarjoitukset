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
    public partial class Form1 : Form
    {
        bool vuoro = true; // true = X turn; false = O turn
        bool against_computer = false;
        int vuoroLaskuri = 0;
        //static String pelaaja1, pelaaja2; 
        // ^ No longer needed, form 2 is not in use 


        public Form1()
        {
            InitializeComponent();
        }

        /*
        public static void annaNimet(String n1, String n2)
        {
            pelaaja1 = n1;
            pelaaja2 = n2;
        }
        */
        // ^ No longer needed, form 2 is not in use


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Game by R.Marin", "Tic Tac Toe About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((p1.Text == "Pelaaja 1") || (p2.Text == "Pelaaja 2"))
            {
                MessageBox.Show("Anna pelaajien nimet! Jos haluat pelata konetta vastaan, /nkirjoita kohtaan Pelaaja 2: 'Tietokone'");
                newGameToolStripMenuItem.PerformClick();
            }
            Button b = (Button)sender;
            if (vuoro)
                b.Text = "X";
            else
                b.Text = "O";
            
            vuoro = !vuoro;
            b.Enabled = false;
            vuoroLaskuri++;

            label3.Focus();
            tarkistaVoittaja();


        if ((!vuoro) && (against_computer))
            {
                computer_make_move();
            }
        }



        private void computer_make_move()
        {
            // priorities: 1.aim to win, 2.block opponent, 3.go for corner, 4. pick open space
            
            Button move = null;

            move = look_for_win_or_block("O");
            if (move == null)
            {
                move = look_for_win_or_block("X");
                if (move == null)
                {
                    move = look_for_corner();
                    if (move == null)
                    {
                        move = look_for_open_space();
                    } //end if
                } //end if
            } //end if

            move.PerformClick();
        }

       


        private Button look_for_open_space()
        {
            Console.WriteLine("Looking for open space");
            Button b = null;
            foreach (Control c in Controls)
            {
                b = c as Button;
                if (b != null)
                {
                    if (b.Text == "")
                        return b;
                } //end if
            } //end if

            return null;
        }

        private Button look_for_corner()
        {
            Console.WriteLine("Looking for corner");
            if (A1.Text == "O")
            {
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }

            if (A3.Text == "O")
            {
                if (A1.Text == "")
                    return A1;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }

            if (C3.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                if (A3.Text == "")
                    return A3;
                if (C1.Text == "")
                    return C1;
            }

            if (C1.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
            }

            if (A1.Text == "")
                return A1;
            if (A3.Text == "")
                return A3;
            if (C1.Text == "")
                return C1;
            if (C3.Text == "")
                return C3;

            return null;
        }

        private Button look_for_win_or_block(string mark)
        {
            Console.WriteLine("Looking for win or block:  " + mark);
            //HORIZONTAL TESTS
            if ((A1.Text == mark) && (A2.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A2.Text == mark) && (A3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (A3.Text == mark) && (A2.Text == ""))
                return A2;

            if ((B1.Text == mark) && (B2.Text == mark) && (B3.Text == ""))
                return B3;
            if ((B2.Text == mark) && (B3.Text == mark) && (B1.Text == ""))
                return B1;
            if ((B1.Text == mark) && (B3.Text == mark) && (B2.Text == ""))
                return B2;

            if ((C1.Text == mark) && (C2.Text == mark) && (C3.Text == ""))
                return C3;
            if ((C2.Text == mark) && (C3.Text == mark) && (C1.Text == ""))
                return C1;
            if ((C1.Text == mark) && (C3.Text == mark) && (C2.Text == ""))
                return C2;

            //VERTICAL TESTS
            if ((A1.Text == mark) && (B1.Text == mark) && (C1.Text == ""))
                return C1;
            if ((B1.Text == mark) && (C1.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (C1.Text == mark) && (B1.Text == ""))
                return B1;

            if ((A2.Text == mark) && (B2.Text == mark) && (C2.Text == ""))
                return C2;
            if ((B2.Text == mark) && (C2.Text == mark) && (A2.Text == ""))
                return A2;
            if ((A2.Text == mark) && (C2.Text == mark) && (B2.Text == ""))
                return B2;

            if ((A3.Text == mark) && (B3.Text == mark) && (C3.Text == ""))
                return C3;
            if ((B3.Text == mark) && (C3.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A3.Text == mark) && (C3.Text == mark) && (B3.Text == ""))
                return B3;

            //DIAGONAL TESTS
            if ((A1.Text == mark) && (B2.Text == mark) && (C3.Text == ""))
                return C3;
            if ((B2.Text == mark) && (C3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (C3.Text == mark) && (B2.Text == ""))
                return B2;

            if ((A3.Text == mark) && (B2.Text == mark) && (C1.Text == ""))
                return C1;
            if ((B2.Text == mark) && (C1.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A3.Text == mark) && (C1.Text == mark) && (B2.Text == ""))
                return B2;

            return null;
        }



        private void tarkistaVoittaja()
        {
            bool voittajaTiedossa = false;

            // Checking horixontal lines
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                voittajaTiedossa = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                voittajaTiedossa = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                voittajaTiedossa = true;

            // Checking vertical lines
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                voittajaTiedossa = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                voittajaTiedossa = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                voittajaTiedossa = true;

            // Checking diagonal lines
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                voittajaTiedossa = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
                voittajaTiedossa = true;



            if (voittajaTiedossa)
            {
                disableButtons();

                string voittaja = "";
                if (vuoro)
                {
                    voittaja = p2.Text;
                    pisteet_O.Text = (Int32.Parse(pisteet_O.Text) + 1).ToString();
                }
                else
                {
                    voittaja = p1.Text;
                    pisteet_X.Text = (Int32.Parse(pisteet_X.Text) + 1).ToString();
                }
                MessageBox.Show("Onnittelut " + voittaja + " voitti pelin!", "Jipii!");
                newGameToolStripMenuItem.PerformClick();
            } //end if
            else
            {
                if (vuoroLaskuri == 9)
                {
                    MessageBox.Show("Tasapeli!", "Uusi yritys?");
                    newGameToolStripMenuItem.PerformClick();
                }
            }


        } // end checkin the winner (tarkistaVoittaja)

        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            } 
            catch { }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vuoro = true;
            vuoroLaskuri = 0;


            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                } //end try
                catch { }

            } // end foreach

        }

        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (vuoro)
                    b.Text = "X";
                else
                    b.Text = "O";
            } //end if
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            } //end if
        }

        private void nollaaPistelaskuritToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pisteet_O.Text = "0";
            pisteet_X.Text = "0";
            Tasapeli.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // No longer needed
           
            /*
            Form2 f2 = new Form2();
            f2.ShowDialog();
            label1.Text = pelaaja1;
            label2.Text = pelaaja2;
            */
            pelaaOletusasetuksillaToolStripMenuItem.PerformClick();
        }

        private void p2_TextChanged(object sender, EventArgs e)
        {
            if (p2.Text.ToUpper() == "TIETOKONE")
                against_computer = true;
            else
                against_computer = false;
        }

        private void pelaaOletusasetuksillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p1.Text = "Ihminen";
            p2.Text = "Tietokone";
        }



    }


}
