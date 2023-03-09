using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrestikiNoliki
{
    public partial class Form1 : Form
    {
        
        string player;
        
        public Form1()
        {
            InitializeComponent();
        }

        public void CreateField()
        {
            player = "X";
            buttons = new Button[3, 3];

            buttons[0, 0] = button1;
            buttons[0, 1] = button2;
            buttons[0, 2] = button3;

            buttons[1, 0] = button4;
            buttons[1, 1] = button5;
            buttons[1, 2] = button6;

            buttons[2, 0] = button7;
            buttons[2, 1] = button8;
            buttons[2, 2] = button9;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j].Text = "";
                }
            }
        }

        public bool isWin()
        {
            for (int i = 0; i < 3; i++)
            {
                if (buttons[i,0].Text == buttons[i,1].Text && buttons[i,1].Text == buttons[i, 2].Text && buttons[i,0].Text != "")
                {
                    return true;
                }
                
                
            }

            for (int i = 0; i < 3; i++)
            {
                if (buttons[0, i].Text == buttons[1, i].Text && buttons[i, 1].Text == buttons[i, 2].Text &&
                    buttons[0, i].Text != "")
                {
                    return true;
                }
            }
            return false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CreateField();
            button10.Visible = false;
            
        }

        private void PutSymbol(object sender, EventArgs e)
        {
            
                if (((Button)sender).Text == "")
                {
                    ((Button)sender).Text = player;
                    if (isWin())
                    {
                        MessageBox.Show($"Победил игрок: {player}");
                        CreateField();
                    }

                    if (player == "X")
                    {
                        player = "O";
                    }
                    else
                    {
                        player = "X";
                    }
                }
                else
                {
                    MessageBox.Show("Клекта уже занята");
                }
            
        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateField();

        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        

        
    }
}
