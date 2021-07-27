using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Ahihi
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //loadMusic();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        //private static void loadMusic()
        //{
        //    WMPLib.WindowsMediaPlayer music = new WMPLib.WindowsMediaPlayer();
        //    music.URL = "CMBELN_01.mp3";
        //    music.controls.play();
        //}
    }
}
