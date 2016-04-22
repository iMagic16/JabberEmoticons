using System;
using System.IO;
using System.Windows.Forms;

namespace JabberEmoticons
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

            //      if (!(File.Exists("MagiCorpDevTools_Debugger.dll")))
            //        {
            Console.WriteLine("MagiCorpDevTools_Debugger.dll installing...");
            File.WriteAllBytes("MagiCorpDevTools_Debugger.dll", Properties.Resources.MagiCorpDevTools_Debugger);
            //       }

            //     if (!(File.Exists("MagiCorpUpdater.exe")))
            //      {
            Console.WriteLine("MagiCorpUpdater.exe installing...");
            File.WriteAllBytes("MagiCorpUpdater.exe", Properties.Resources.MagiCorpUpdater);
            //     }

            Console.WriteLine("Starting main application......");
            try
            {
                Application.Run(new FrmMain());

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
              //  throw;
            }
        }
    }
}
