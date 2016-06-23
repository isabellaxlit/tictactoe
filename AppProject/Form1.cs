using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AppProject
{
    public partial class Form1 : Form
    {
        

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
        private void check()
        {
            bool winner = false;
            //Horizontal checking
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                winner = true; 
            //Vertical Checking
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                winner = true;
            //Oblique Checking
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text)&&(!A1.Enabled))
                winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
                winner = true;

            if(winner)
            {
                disableButtons();
                String win = "";
                if (turn)
                    win = " O ";
                else
                    win = " X ";
                MessageBox.Show(win + "Wins ! ", "Yay");               
            }
            else
            {
                if (turn_count == 9)
                    MessageBox.Show("Draw !", "bummer");
            }
       }//End of class



        bool turn = true;//true = X turn; false = Y turn
        int turn_count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A simple game for future CNF cyber security camp members to be super jealous of the first class", "Tic Tac Toe About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }//end foreach                                                     
            }//end try
            catch { }
        }

        private void button_click(object sender, EventArgs e)
        {
              

            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            turn_count++;
            check();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}