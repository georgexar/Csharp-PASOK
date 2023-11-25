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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void buttonstart_Click(object sender, EventArgs e)
        {
           BATTLE game = new BATTLE();
            game.ShowDialog();
        }

        private void buttonquit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
