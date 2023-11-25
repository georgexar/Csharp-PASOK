using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERGASIA_ALEPI
{
    public partial class BATTLE : Form
    {
        //public static List<int> scorelist = new List<int>(); LISTA ME TA SCORES
        //string file_path = @"file.txt";
 
       

        collision Collision;
        
       public static List<PictureBox> coin = new List<PictureBox>();
        public static List<PictureBox> poop = new List<PictureBox>();
        
        Random r=new Random();
        bool goleft, goright, goup, godown;
        int playerlife = 10;
        int speed = 10;
        public static int score = 0;
     


        public BATTLE()
        {
            
            Collision = new collision(this);
            InitializeComponent();

            this.BackgroundImage = null;
            this.BackColor = Color.Black;
        }



        private void BATTLE_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                goright = false;


            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {

                godown = false;


            }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {

                goup = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                //
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label_score.Text = "Score :" + score;

            foreach (PictureBox p in coin)
            {
                p.Location = new Point(p.Location.X, p.Location.Y - 10);
            }

            Collision.DetectCollision();


        }

        public void endGame()
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            GAMEOVER gameover = new GAMEOVER(score);
            gameover.ShowDialog();
            this.Close();


        }

       

        private void timer2_Tick(object sender, EventArgs e)
        {
            enemy.Location = new Point(r.Next(Width - enemy.Width), enemy.Location.Y);
             createPoop(enemy.Location.X); 

            
        }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox box in poop)
            {
                box.Location = new Point(box.Location.X, box.Location.Y + 3);
            }



        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                goleft = true;

            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                goright = true;

            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                godown = true;

            }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                goup = true;
              
            }
            if (e.KeyCode.ToString().Equals("Space"))
            {
                createCoin(player.Location.X);
            }


        }

        private void movement_Tick(object sender, EventArgs e)
        {
            if (goleft == true && player.Left > 0) { player.Left -= speed; }
            if (goright == true && player.Left + player.Width < this.ClientSize.Width) { player.Left += speed; }
            if (goup == true && player.Top > 120) { player.Top -= speed; }
            if (godown == true && player.Top + player.Height < ClientSize.Height - 100) { player.Top += speed; }
        }

        private void createCoin(int startX)
        {                                  
            PictureBox p = new PictureBox();
            p.Image = ((Image)Properties.Resources.coin); 
            p.Location = new Point(startX +30, player.Location.Y - 50);
            p.Size = new Size(40, 30);
            p.SizeMode = PictureBoxSizeMode.StretchImage;
            p.BackColor = Color.Transparent;
            Controls.Add(p);
            coin.Add(p);
        }
        private void createPoop(int startX)
        {                               
            PictureBox k = new PictureBox();
            k.ImageLocation = "poop.png";
            k.Location = new Point(startX + 30, enemy.Location.Y + 50);           
            k.Size = new Size(60, 50);
            k.SizeMode = PictureBoxSizeMode.StretchImage;
            k.BackColor = Color.Transparent;
            Controls.Add(k);
            poop.Add(k);
        
            
        }

        


    }
}
