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
        public Form1()
        {
            InitializeComponent();
        }
        int player = 0;
        int box1, box2, box3, box4, box5, box6, box7, box8, box9;
        void check()
        {
            if (box1 == 1 && box2 == 1 && box3 == 1)
            {
                pictureBox1.Image = Properties.Resources.CircleWin;
                pictureBox2.Image = Properties.Resources.CircleWin;
                pictureBox3.Image = Properties.Resources.CircleWin;
                MessageBox.Show("Player 1 wins");
            }
            if (box4 == 1 && box5 == 1 && box6 == 1)
            {
                pictureBox4.Image = Properties.Resources.CircleWin;
                pictureBox5.Image = Properties.Resources.CircleWin;
                pictureBox6.Image = Properties.Resources.CircleWin;
                MessageBox.Show("Player 1 wins");
            }
            if (box7 == 1 && box8 == 1 && box9 == 1)
            {
                pictureBox7.Image = Properties.Resources.CircleWin;
                pictureBox8.Image = Properties.Resources.CircleWin;
                pictureBox9.Image = Properties.Resources.CircleWin;
                MessageBox.Show("Player 1 wins");
            }
            if (box1 == 1 && box4 == 1 && box7 == 1)
            {
                pictureBox1.Image = Properties.Resources.CircleWin;
                pictureBox4.Image = Properties.Resources.CircleWin;
                pictureBox7.Image = Properties.Resources.CircleWin;
                MessageBox.Show("Player 1 wins");
            }
            if (box2 == 1 && box5 == 1 && box8 == 1)
            {
                pictureBox2.Image = Properties.Resources.CircleWin;
                pictureBox5.Image = Properties.Resources.CircleWin;
                pictureBox8.Image = Properties.Resources.CircleWin;
                MessageBox.Show("Player 1 wins");
            }
            if (box3 == 1 && box6 == 1 && box9 == 1)
            {
                pictureBox3.Image = Properties.Resources.CircleWin;
                pictureBox6.Image = Properties.Resources.CircleWin;
                pictureBox9.Image = Properties.Resources.CircleWin;
                MessageBox.Show("Player 1 wins");
            }
            if (box1 == 1 && box5 == 1 && box9 == 1)
            {
                pictureBox1.Image = Properties.Resources.CircleWin;
                pictureBox5.Image = Properties.Resources.CircleWin;
                pictureBox9.Image = Properties.Resources.CircleWin;
                MessageBox.Show("Player 1 wins");
            }
            if (box3 == 1 && box5 == 1 && box7 == 1)
            {
                pictureBox3.Image = Properties.Resources.CircleWin;
                pictureBox5.Image = Properties.Resources.CircleWin;
                pictureBox7.Image = Properties.Resources.CircleWin;
                MessageBox.Show("Player 1 wins");
            }
            if (box1 == 2 && box2 == 2 && box3 == 2)
            {
                pictureBox1.Image = Properties.Resources.CrossWin;
                pictureBox2.Image = Properties.Resources.CrossWin;
                pictureBox3.Image = Properties.Resources.CrossWin;
                MessageBox.Show("Player 2 wins");
            }
            if (box4 == 2 && box5 == 2 && box6 == 2)
            {
                pictureBox4.Image = Properties.Resources.CrossWin;
                pictureBox5.Image = Properties.Resources.CrossWin;
                pictureBox6.Image = Properties.Resources.CrossWin;
                MessageBox.Show("Player 2 wins");
            }
            if (box7 == 2 && box8 == 2 && box9 == 2)
            {
                pictureBox7.Image = Properties.Resources.CrossWin;
                pictureBox8.Image = Properties.Resources.CrossWin;
                pictureBox9.Image = Properties.Resources.CrossWin;
                MessageBox.Show("Player 2 wins");
            }
            if (box1 == 2 && box4 == 2 && box7 == 2)
            {
                pictureBox1.Image = Properties.Resources.CrossWin;
                pictureBox4.Image = Properties.Resources.CrossWin;
                pictureBox7.Image = Properties.Resources.CrossWin;
                MessageBox.Show("Player 2 wins");
            }
            if (box2 == 2 && box5 == 2 && box8 == 2)
            {
                pictureBox2.Image = Properties.Resources.CrossWin;
                pictureBox5.Image = Properties.Resources.CrossWin;
                pictureBox8.Image = Properties.Resources.CrossWin;
                MessageBox.Show("Player 2 wins");
            }
            if (box3 == 2 && box6 == 2 && box9 == 2)
            {
                pictureBox3.Image = Properties.Resources.CrossWin;
                pictureBox6.Image = Properties.Resources.CrossWin;
                pictureBox9.Image = Properties.Resources.CrossWin;
                MessageBox.Show("Player 2 wins");
            }
            if (box1 == 2 && box5 == 2 && box9 == 2)
            {
                pictureBox1.Image = Properties.Resources.CrossWin;
                pictureBox5.Image = Properties.Resources.CrossWin;
                pictureBox9.Image = Properties.Resources.CrossWin;
                MessageBox.Show("Player 2 wins");
            }
            if (box3 == 2 && box5 == 2 && box7 == 2)
            {
                pictureBox3.Image = Properties.Resources.CrossWin;
                pictureBox5.Image = Properties.Resources.CrossWin;
                pictureBox7.Image = Properties.Resources.CrossWin;
                MessageBox.Show("Player 2 wins");
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (player == 0)
            {
                pictureBox1.Image = Properties.Resources.Circle;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                player = 1;
                pictureBox1.Enabled = false;
                box1 = 1;
                check();
                label2.Text = "Player 2's turn";
            }
            else if (player == 1)
            {
                pictureBox1.Image = Properties.Resources.Cross;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                player = 0;
                pictureBox1.Enabled = false;
                box1 = 2;
                check();
                label2.Text = "Player 1's turn";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (player == 0)
            {
                pictureBox2.Image = Properties.Resources.Circle;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                player = 1;
                pictureBox2.Enabled = false;
                box2 = 1;
                check();
                label2.Text = "Player 2's turn";
            }
            else if (player == 1)
            {
                pictureBox2.Image = Properties.Resources.Cross;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                player = 0;
                pictureBox2.Enabled = false;
                box2 = 2;
                check();
                label2.Text = "Player 1's turn";
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (player == 0)
            {
                pictureBox3.Image = Properties.Resources.Circle;
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                player = 1;
                pictureBox3.Enabled = false;
                box3 = 1;
                check();
                label2.Text = "Player 2's turn";
            }
            else if (player == 1)
            {
                pictureBox3.Image = Properties.Resources.Cross;
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                player = 0;
                pictureBox3.Enabled = false;
                box3 = 2;
                check();
                label2.Text = "Player 1's turn";
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (player == 0)
            {
                pictureBox4.Image = Properties.Resources.Circle;
                pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                player = 1;
                pictureBox4.Enabled = false;
                box4 = 1;
                check();
                label2.Text = "Player 2's turn";
            }
            else if (player == 1)
            {
                pictureBox4.Image = Properties.Resources.Cross;
                pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                player = 0;
                pictureBox4.Enabled = false;
                box4 = 2;
                check();
                label2.Text = "Player 1's turn";
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (player == 0)
            {
                pictureBox5.Image = Properties.Resources.Circle;
                pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                player = 1;
                pictureBox5.Enabled = false;
                box5 = 1;
                check();
                label2.Text = "Player 2's turn";
            }
            else if (player == 1)
            {
                pictureBox5.Image = Properties.Resources.Cross;
                pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                player = 0;
                pictureBox5.Enabled = false;
                box5 = 2;
                check();
                label2.Text = "Player 1's turn";
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (player == 0)
            {
                pictureBox6.Image = Properties.Resources.Circle;
                pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
                player = 1;
                pictureBox6.Enabled = false;
                box6 = 1;
                check();
                label2.Text = "Player 2's turn";
            }
            else if (player == 1)
            {
                pictureBox6.Image = Properties.Resources.Cross;
                pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
                player = 0;
                pictureBox6.Enabled = false;
                box6 = 2;
                check();
                label2.Text = "Player 1's turn";
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (player == 0)
            {
                pictureBox7.Image = Properties.Resources.Circle;
                pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
                player = 1;
                pictureBox7.Enabled = false;
                box7 = 1;
                check();
                label2.Text = "Player 2's turn";
            }
            else if (player == 1)
            {
                pictureBox7.Image = Properties.Resources.Cross;
                pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
                player = 0;
                pictureBox7.Enabled = false;
                box7 = 2;
                check();
                label2.Text = "Player 1's turn";
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (player == 0)
            {
                pictureBox8.Image = Properties.Resources.Circle;
                pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
                player = 1;
                pictureBox8.Enabled = false;
                box8 = 1;
                check();
                label2.Text = "Player 2's turn";
            }
            else if (player == 1)
            {
                pictureBox8.Image = Properties.Resources.Cross;
                pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
                player = 0;
                pictureBox8.Enabled = false;
                box8 = 2;
                check();
                label2.Text = "Player 1's turn";
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (player == 0)
            {
                pictureBox9.Image = Properties.Resources.Circle;
                pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
                player = 1;
                pictureBox9.Enabled = false;
                box9 = 1;
                check();
                label2.Text = "Player 2's turn";
            }
            else if (player == 1)
            {
                pictureBox9.Image = Properties.Resources.Cross;
                pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
                player = 0;
                pictureBox9.Enabled = false;
                box9 = 2;
                check();
                label2.Text = "Player 1's turn";
            }
        }
    }
}
