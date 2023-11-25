using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERGASIA_ALEPI
{
    
    public class collision
    {
        BATTLE gamescreen;

        public collision( BATTLE gameScreen)
        {
            gamescreen = gameScreen;
        }

        

        public void DetectCollision() 
        {
            foreach ( Control control in gamescreen.Controls ) 
            {
                if(control is PictureBox)
                {
                    PictureBox box = (PictureBox)control;

                    if(box.ImageLocation == "poop.png")
                    { 
                        playerhit(box);
                        

                    }
                    else if(box.Image == gamescreen.enemy.Image)
                    {
                        
                        enemyhit(box);
                    }
                }

            }
        
        
        }

        
        public void playerhit(Control box) 
        {

            if (gamescreen.player.Bounds.IntersectsWith(box.Bounds)) 
            {
                if (gamescreen.lifebar.Value > 0)
                {
                    gamescreen.lifebar.Value -= 1;
                    if (gamescreen.lifebar.Value == 0) { gamescreen.endGame(); }
                }
                gamescreen.Controls.Remove(box);
                ((PictureBox)box).Dispose();
            }
                  
        
        }

        public void enemyhit(Control enemy) 
        {

            foreach (PictureBox coins in BATTLE.coin)
            {

                if (enemy.Bounds.IntersectsWith(coins.Bounds))
                {
                    
                    BATTLE.score += 1;
                   

                    coins.SetBounds(0, 0, 0, 0);
                    coins.Dispose();
                    
                }
            }

        
        }
    }
}
