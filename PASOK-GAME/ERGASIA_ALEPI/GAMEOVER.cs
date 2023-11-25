using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERGASIA_ALEPI
{
    public partial class GAMEOVER : Form
    {
        int finalscore;
        public GAMEOVER(int score)
        {
            InitializeComponent();
            finalscore = score;
        }

        private void GAMEOVER_Load(object sender, EventArgs e)
        {

            label1.Text = "Score: " + finalscore;
        }

        private void ButtonMainMenu(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonquit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
