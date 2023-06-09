using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointYapısı
{
    public partial class Form1 : Form
    {
        int boruhızı = 8;
        int gravity = 10;
        int score = 0;
       

        public Form1()
        {
            InitializeComponent();
        }

        private void gamerTimer(object sender, EventArgs e)
        {
            bird.Top += gravity;
            Borualt.Left -= boruhızı;
            Boruust.Left -= boruhızı;
            scortxt.Text = "Score: " + score;
            if(Borualt.Left <-150)
            {
                Borualt.Left = 800;
                score++;

            }
            if(Boruust.Left < -180)
            {
                Boruust.Left = 950;
                score++;

            }
            if(bird.Bounds.IntersectsWith(Borualt.Bounds) || bird.Bounds.IntersectsWith(Boruust.Bounds) || bird.Bounds.IntersectsWith(zemin.Bounds))
            {
                End();
               
            }

            if(bird.Top < -25)
            {
                End();
            }
        }

        private void gameskeydown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = +10;
            }
            bool game = scortxt.Text == "GameOver";

            if (e.KeyCode == Keys.R && game)
            {
                
                RestartGame();
            }

            if(scortxt.Text == "GameOver")
            {
                res.Visible = true;
            }
            else
            {
                res.Visible = false;
            }      
        }

        private void End()
        {
            gameTimer.Stop();
            scortxt.Text = "GameOver";
           
        }

        private void RestartGame()
        {
            
            bird.Location = new Point(36, 259);
            Boruust.Left = 800;
            Borualt.Left = 1200;
            score = 0;
            gravity= 8;
            scortxt.Text = "Score: 0";
            gameTimer.Start();

        }

        private void res_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
