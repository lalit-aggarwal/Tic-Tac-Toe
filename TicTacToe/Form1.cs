using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void XWin()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("Player X Won");
                label6.Text = (Convert.ToInt32(label6.Text) + 1).ToString();
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                MessageBox.Show("Player X Won");
                label6.Text = (Convert.ToInt32(label6.Text) + 1).ToString();
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("Player X Won");
                label6.Text = (Convert.ToInt32(label6.Text) + 1).ToString();
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("Player X Won");
                label6.Text = (Convert.ToInt32(label6.Text) + 1).ToString();
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                MessageBox.Show("Player X Won");
                label6.Text = (Convert.ToInt32(label6.Text) + 1).ToString();
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("Player X Won");
                label6.Text = (Convert.ToInt32(label6.Text) + 1).ToString();
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("Player X Won");
                label6.Text = (Convert.ToInt32(label6.Text) + 1).ToString();
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("Player X Won");
                label6.Text = (Convert.ToInt32(label6.Text) + 1).ToString();
            }
        }

        private void OWin()
        {
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("Player O Won");
                label5.Text = (Convert.ToInt32(label5.Text) + 1).ToString();
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                MessageBox.Show("Player O Won");
                label5.Text = (Convert.ToInt32(label5.Text) + 1).ToString();
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("Player O Won");
                label5.Text = (Convert.ToInt32(label5.Text) + 1).ToString();
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("Player O Won");
                label5.Text = (Convert.ToInt32(label5.Text) + 1).ToString();
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                MessageBox.Show("Player O Won");
                label5.Text = (Convert.ToInt32(label5.Text) + 1).ToString();
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("Player O Won");
                label5.Text = (Convert.ToInt32(label5.Text) + 1).ToString();
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("Player O Won");
                label5.Text = (Convert.ToInt32(label5.Text) + 1).ToString();
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("Player O Won");
                label5.Text = (Convert.ToInt32(label5.Text) + 1).ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "X")
            {
                button1.Text = "X";
                label1.Text = "O";
            }
            else
            {
                button1.Text = "O";
                label1.Text = "X";
            }
            button1.Enabled = false;
            XWin();
            OWin();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "X")
            {
                button2.Text = "X";
                label1.Text = "O";
            }
            else
            {
                button2.Text = "O";
                label1.Text = "X";
            }
            button2.Enabled = false;
            XWin();
            OWin();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "X")
            {
                button3.Text = "X";
                label1.Text = "O";
            }
            else
            {
                button3.Text = "O";
                label1.Text = "X";
            }
            button3.Enabled = false;
            XWin();
            OWin();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text == "X")
            {
                button4.Text = "X";
                label1.Text = "O";
            }
            else
            {
                button4.Text = "O";
                label1.Text = "X";
            }
            button4.Enabled = false;
            XWin();
            OWin();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text == "X")
            {
                button5.Text = "X";
                label1.Text = "O";
            }
            else
            {
                button5.Text = "O";
                label1.Text = "X";
            }
            button5.Enabled = false;
            XWin();
            OWin();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text == "X")
            {
                button6.Text = "X";
                label1.Text = "O";
            }
            else
            {
                button6.Text = "O";
                label1.Text = "X";
            }
            button6.Enabled = false;
            XWin();
            OWin();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text == "X")
            {
                button7.Text = "X";
                label1.Text = "O";
            }
            else
            {
                button7.Text = "O";
                label1.Text = "X";
            }
            button7.Enabled = false;
            XWin();
            OWin();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text == "X")
            {
                button8.Text = "X";
                label1.Text = "O";
            }
            else
            {
                button8.Text = "O";
                label1.Text = "X";
            }
            button8.Enabled = false;
            XWin();
            OWin();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text == "X")
            {
                button9.Text = "X";
                label1.Text = "O";
            }
            else
            {
                button9.Text = "O";
                label1.Text = "X";
            }
            button9.Enabled = false;
            XWin();
            OWin();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            restart();
            label1.Text = "X";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            restart();
            label1.Text = "X";
            label5.Text = label6.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restart()
        {
            button1.Text = " ";
            button1.Enabled = true;
            button2.Text = " ";
            button2.Enabled = true;
            button3.Text = " ";
            button3.Enabled = true;
            button4.Text = " ";
            button4.Enabled = true;
            button5.Text = " ";
            button5.Enabled = true;
            button6.Text = " ";
            button6.Enabled = true;
            button7.Text = " ";
            button7.Enabled = true;
            button8.Text = " ";
            button8.Enabled = true;
            button9.Text = " ";
            button9.Enabled = true;
        }
    }
}
