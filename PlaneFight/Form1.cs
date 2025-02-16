using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PlaneFight
{
    public partial class Form1 : Form
    {
        //playerMoves
        int moveLeft = 0;
        int EnemyMove = 5;
        Random r = new Random();
        int bulletSpd = -8;
        bool shooting = false;
        int score = 0;
        public Form1()
        {
           
            InitializeComponent();
            Ememy1.Top = -500;
            Ememy1.Top = -900;
            Ememy1.Top = -1300;
            Bullet.Top = -100;
            Bullet.Left = -100;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkTurquoise;
            this.Text = "Plane Game";
            Thread.Sleep(2000);
            label2.Visible = true;
        }

        private void onKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Down)
            {
                timer1.Stop();
                label2.Visible = true;
            }
            if (e.KeyCode==Keys.PageUp)
            {
                score += 10;
            }
            if (e.KeyCode==Keys.Space)
            {
                timer1.Enabled = true;
                label2.Visible = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                if (Player.Location.X<0)
                {
                    moveLeft = 0;
                }
                else
                {
                    moveLeft = -5;
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                if (Player.Location.X >512)
                {
                    moveLeft = 0;
                }
                else
                {
                    moveLeft = 5;
                }
                
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (shooting == false)
                {
                    shooting = true;
                    bulletSpd = -8;
                    Bullet.Left = Player.Left + 50;
                    Bullet.Top = Player.Top;
                    shooting = true;
                }
            }
        }

        private void onKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                moveLeft = 0;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveLeft = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            enemyHit();
            Player.Left += moveLeft;
            Bullet.Top += bulletSpd;
            Ememy1.Top += EnemyMove;
            Ememy2.Top += EnemyMove;
            Ememy3.Top += EnemyMove;
            label1.Text = "" + score;
            if (Ememy1.Top == 660 || Ememy2.Top == 660 || Ememy3.Top == 660)
            {
                GameOver();
            }
            if (shooting && Bullet.Top<0)
            {
                bulletSpd = 0;
                Bullet.Top = -100;
                Bullet.Left = -100;
                
            }
            if (Bullet.Top>ClientSize.Height || Bullet.Top<0)
            {
                shooting = false;
            }
            
                
        }
        private void enemyHit()
        {
            if (Bullet.Bounds.IntersectsWith(Ememy1.Bounds))
            {
                score++;
                Ememy1.Top = -510;
                int ranP = r.Next(1, 300);
                Ememy1.Left = ranP;
                shooting = false;
                bulletSpd = 0;
                Bullet.Top = -100;
                Bullet.Left = -100;
                shooting = false;

            }
            if (Bullet.Bounds.IntersectsWith(Ememy2.Bounds))
            {
                score++;
                Ememy1.Top = -510;
                int ranP = r.Next(1, 300);
                Ememy1.Left = ranP;
                shooting = false;
                bulletSpd = 0;
                Bullet.Top = -100;
                Bullet.Left = -100;

            }
            if (Bullet.Bounds.IntersectsWith(Ememy3.Bounds))
            {
                score++;
                Ememy1.Top = -500;
                int ranP = r.Next(1, 300);
                Ememy1.Left = ranP;
                shooting = false;
                bulletSpd = 0;
                Bullet.Top = -100;
                Bullet.Left = -100;

            }
        }
        private void GameOver()
        {
            timer1.Enabled = false;
            MessageBox.Show("Score: " + score + "\r\nContinue?" );
            score = 0;
            Ememy1.Top = -500;
            Ememy2.Top = -900;
            Ememy3.Top = -1300;
            Bullet.Top = -100;
            Bullet.Left = -100;
            timer1.Enabled = true;
            Application.Restart();
        }
        private void Pause()
        {

        }
    }
}
