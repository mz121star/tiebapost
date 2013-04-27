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

            int a = SystemHelper.GetOSBit();
            if (!File.Exists(ENV.BaseDir + "/SharpSvn.dll"))
            {
                if (a == 64)
                {
                    File.Copy(ENV.BaseDir + "/sharpsvn/SharpSvnx64.dll", ENV.BaseDir + "/SharpSvn.dll", true);
                }
                else
                {
                    File.Copy(ENV.BaseDir + "/sharpsvn/SharpSvnx86.dll", ENV.BaseDir + "/SharpSvn.dll", true);
                }
            }
            Application.Run(new Form1());


        }
    }
}
