﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacMan
{
    public partial class Game : Form
    {
        string sameUser;
        bool goUp;
        bool goDown;
        bool goLeft;
        bool goRight;

        int speed = 5;
        int PinkGhostx = 3;
        int PinkGhosty = 5;
        int RedGhostx = 5;
        int RedGhosty = 3;

        int score = 0;
        public Game(string UserName)
        {
            InitializeComponent();
            sameUser = UserName;
            label_UserName.Text = UserName;
            label2.Visible = false;
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                pictureBox_Pacman.Image = Properties.Resources.pacman_left;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                pictureBox_Pacman.Image = Properties.Resources.pacman_right;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                pictureBox_Pacman.Image = Properties.Resources.pacman_up;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                pictureBox_Pacman.Image = Properties.Resources.pacman_down;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Score: " + score;

            if (goLeft)
            {
                pictureBox_Pacman.Left -= speed;
            }
            if (goRight)
            {
                pictureBox_Pacman.Left += speed;
            }
            if (goUp)
            {
                pictureBox_Pacman.Top -= speed;
            }
            if (goDown)
            {
                pictureBox_Pacman.Top += speed;
            }
            pictureBox_RedG.Left += RedGhostx;
            pictureBox_RedG.Top += RedGhosty;
            pictureBox_pinkG.Left += PinkGhostx;
            pictureBox_pinkG.Top += PinkGhosty;
            //fantasma rojo
            if (pictureBox_RedG.Left < 1 ||
                pictureBox_RedG.Left + pictureBox_RedG.Width > ClientSize.Width - 2 ||
                pictureBox_RedG.Bounds.IntersectsWith(pictureBox_RightWall.Bounds) ||
                pictureBox_RedG.Bounds.IntersectsWith(pictureBox_LeftWall.Bounds))
            {
                RedGhostx = -RedGhostx;
            }
            else if (pictureBox_RedG.Top < 1 ||
                    pictureBox_RedG.Top + pictureBox_RedG.Height > ClientSize.Height - 2 ||
                    pictureBox_RedG.Bounds.IntersectsWith(pictureBox_TopWall.Bounds) ||
                    pictureBox_RedG.Bounds.IntersectsWith(picture_BottomWall.Bounds))
            {
                RedGhosty = -RedGhosty;
            }
            //fantasma rosado
            if (pictureBox_pinkG.Left < 1 ||
                pictureBox_pinkG.Left + pictureBox_RedG.Width > ClientSize.Width - 2 || 
                pictureBox_pinkG.Bounds.IntersectsWith(pictureBox_RightWall.Bounds) ||
                pictureBox_pinkG.Bounds.IntersectsWith(pictureBox_LeftWall.Bounds))
            {
                PinkGhostx = -PinkGhostx;
            }
            else if (pictureBox_pinkG.Top < 1 ||
                    pictureBox_pinkG.Top + pictureBox_RedG.Height > ClientSize.Height - 2 || 
                    pictureBox_pinkG.Bounds.IntersectsWith(pictureBox_TopWall.Bounds) ||
                    pictureBox_pinkG.Bounds.IntersectsWith(picture_BottomWall.Bounds))
            {
                PinkGhosty = -PinkGhosty;
            }
            //Frutas
            
            Random random = new Random();
            int FruitChoise = random.Next(2); //2 esta hardcodiado, cambiarlo en el caso que se agreguen frutas
            if (FruitChoise == 0)
            {
                int rdmX = random.Next(625);
                int rdmY = random.Next(570);
                var picture = new PictureBox
                {
                    Name = "pictureBox_cherry",
                    Size = new Size(40, 40),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Tag = "cherry",
                    Location = new Point(rdmX, rdmY),
                    Image = Properties.Resources.cherry,
                };
                foreach (Control control in this.Controls)
                {
                    if (control is PictureBox && ((PictureBox)control).Bounds.IntersectsWith(picture.Bounds))
                    {
                        continue;
                    }
                    else
                    {
                        this.Controls.Add(picture);
                    }
                }
            }
            else if (FruitChoise == 1)
            {
                int rdmX = random.Next(625);
                int rdmY = random.Next(570);
                var picture = new PictureBox
                {
                    Name = "pictureBox_grape",
                    Size = new Size(40, 40),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Tag = "cherry",
                    Location = new Point(rdmX, rdmY),
                    Image = Properties.Resources.tile114,
                };
                foreach (Control control in this.Controls)
                {
                    if (control is PictureBox && ((PictureBox)control).Bounds.IntersectsWith(picture.Bounds))
                    {
                        continue;
                    }
                    else
                    {
                        this.Controls.Add(picture);
                    }
                }
            }

            foreach (Control control in this.Controls)
            {
                if (control is PictureBox && control.Tag == "wall" || control.Tag == "ghost")
                {
                    if (((PictureBox)control).Bounds.IntersectsWith(pictureBox_Pacman.Bounds))
                    {
                        pictureBox_Pacman.Left = 0;
                        pictureBox_Pacman.Top = 25;
                        label2.Text = "GAME OVER";
                        label2.Visible = true;
                        timer1.Stop();
                        var Choise = MessageBox.Show("Again?", "Choosing", MessageBoxButtons.YesNo);
                        if (Choise == DialogResult.Yes)
                        {
                            Close();
                            Game newGame = new Game(sameUser);
                            newGame.Show();
                        }
                        else
                        {
                            Close();
                            Application.Exit();
                        }
                    }
                }
                if (control is PictureBox && control.Tag == "cherry")
                {
                    if (((PictureBox)control).Bounds.IntersectsWith(pictureBox_Pacman.Bounds))
                    {
                        this.Controls.Remove(control);
                        score += 10;
                    }
                }
                if (control is PictureBox && control.Tag == "grape")
                {
                    if (((PictureBox)control).Bounds.IntersectsWith(pictureBox_Pacman.Bounds))
                    {
                        this.Controls.Remove(control);
                        score += 15;
                    }
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
    }
}
