using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AcertoCTe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Arquivo.CopiarArquivos();
            }
            catch
            {
            }
            finally
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }
    }
}
