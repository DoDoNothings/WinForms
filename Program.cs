using BeginingWinForms.Game;
using BeginingWinForms.Resume;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeginingWinForms
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Resume_.ShowMessageBoxes();//задание 1
            //Hidden_Number.Play();//задание 2
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Click_Rectangle.Click());
            // Application.Run(new Static.Runing_Static());
            //Application.Run(new Day_of_Week.Day());
            //Application.Run(new CountDays.Count_days());
            // Application.Run(new _Rectangle.Rectangles());
        }

    }
}
