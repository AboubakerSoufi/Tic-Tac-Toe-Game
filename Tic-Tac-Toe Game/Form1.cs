using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;
        }
        bool GameOver = false;

        private void WinningLineColoring(PictureBox pb1, PictureBox pb2, PictureBox pb3)
        {
            pb1.BackColor = Color.LightGreen;
            pb2.BackColor = Color.LightGreen;
            pb3.BackColor = Color.LightGreen;

        }
        private void ResetGame()
        {
            GameOver = false;
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox pb && pb.Name != "pictureBox10")
                {
                    pb.Image = Properties.Resources.question_mark_96;

                    pb.Tag = 0;
                    pb.BackColor = Color.Black;
                    pb.Enabled = true;
                }
            }

            lbTurn.Text = "Player 1";
            lbTurn.Tag = 1;

            lbWinner.Text = "In Progress";
        }
        private void Winner(object player)
        {
            if (GameOver)
                return;

            GameOver = true;
            string message ="";
            if (player == null)
                 message ="Draw";
            else
                 message = (player.ToString() == "1") ? "Player 1 Wins!" : "Player 2 Wins!";
            lbWinner.Text = message;
          
            // إيقاف اللعب
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox pb)
                {
                    pb.Enabled = false;
                }
            }

            MessageBox.Show( message + "\nGame Over","Game Over",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
        }    
        private void CheckWinner()
        {
           

            int p1 = Convert.ToInt32(pictureBox1.Tag ?? 0);
            int p2 = Convert.ToInt32(pictureBox2.Tag ?? 0);
            int p3 = Convert.ToInt32(pictureBox3.Tag ?? 0);
            int p4 = Convert.ToInt32(pictureBox4.Tag ?? 0);
            int p5 = Convert.ToInt32(pictureBox5.Tag ?? 0);
            int p6 = Convert.ToInt32(pictureBox6.Tag ?? 0);
            int p7 = Convert.ToInt32(pictureBox7.Tag ?? 0);
            int p8 = Convert.ToInt32(pictureBox8.Tag ?? 0);
            int p9 = Convert.ToInt32(pictureBox9.Tag ?? 0);
            // الصف الأول
            if (p1 != 0 && p1 == p2 && p2 == p3)
            {
                WinningLineColoring(pictureBox1, pictureBox2, pictureBox3);
                Winner(p1);  
            }

            // الصف الثاني
            else if (p4 != 0 && p4 == p5 && p5 == p6)
            {
                WinningLineColoring(pictureBox4, pictureBox5, pictureBox6);
                Winner(p4);
            }

            // الصف الثالث
            else if (p7 != 0 && p7 == p8 && p8 == p9)
                {
                    WinningLineColoring(pictureBox7, pictureBox8, pictureBox9);
                    Winner(p7);
            }

            // العمود الأول
            else if (p1 != 0 && p1 == p4 && p4 == p7)
                    {
                        WinningLineColoring(pictureBox1, pictureBox4, pictureBox7);
                        Winner(p1);
            }

            // العمود الثاني
            else if (p2 != 0 && p2 == p5 && p5 == p8)
                        {
                            WinningLineColoring(pictureBox2, pictureBox5, pictureBox8);
                            Winner(p2);
            }
            // العمود الثالث
            else if (p3 != 0 && p3 == p6 && p6 == p9)
                            {
                                WinningLineColoring(pictureBox3, pictureBox6, pictureBox9);
                                Winner(p3);
            }

            // القطر الرئيسي
            else if (p1 != 0 && p1 == p5 && p5 == p9)
                                {
                                    WinningLineColoring(pictureBox1, pictureBox5, pictureBox9);
                                    Winner(p1);
            }

            // القطر الثاني
            else if (p3 != 0 && p3 == p5 && p5 == p7)
                                    {
                                        WinningLineColoring(pictureBox3, pictureBox5, pictureBox7);
                                        Winner(p3);
            }
            else if (p1 != 0 && p2 != 0 && p3 != 0 && p4 != 0 && p5 != 0 && p6 != 0 && p7 != 0 && p8 != 0 && p9 != 0)
                Winner(null);
        }
        private void PlayMove(PictureBox pb)
        {
            if (Convert.ToInt32(pb.Tag) != 0)
            {

                MessageBox.Show("Wrond Choice", "Wrong",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                
                // منع الضغط مرتين

            int player = Convert.ToInt32(lbTurn.Tag);

            if (player == 1)
            {
                pb.Image = Properties.Resources.X; // صورة X
                lbTurn.Text = "Player 2";
                lbTurn.Tag = 2;
            }
            else
            {
                pb.Image = Properties.Resources.O; // صورة O
                lbTurn.Text = "Player 1";
                lbTurn.Tag = 1;
            }

            pb.Tag = player; // نخزن من لعب هنا

            CheckWinner();
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255);

            Pen pen = new Pen(White);
            pen.Width = 10;

            e.Graphics.DrawLine(pen, 400, 460, 1050, 460);
            e.Graphics.DrawLine(pen, 400, 300, 1050, 300);
            e.Graphics.DrawLine(pen, 610, 140, 610, 620);
            e.Graphics.DrawLine(pen, 810, 140, 810, 620);
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pb)
            {
                PlayMove(pb);
            }
        }
       
        private void btRestartGame_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }
    }
}
