using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using core;

namespace baidutieba
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!File.Exists(ENV.BaseDir + "/school.txt"))
            {
                var sw = File.Create(ENV.BaseDir + "/school.txt");
                sw.Close();
            }
            Application.Run(new Form1());


        }
    }
}
