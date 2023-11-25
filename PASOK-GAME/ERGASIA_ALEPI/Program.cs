using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERGASIA_ALEPI
{


    public enum Direction
    {
        up,
        down,
        left,
        right,
    }


    internal static class Program
    {

        public static PictureBox user;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new BATTLE());
            Application.Run(new MainMenu());
        }
    }
}
