using System;
using System.Windows.Forms;
using PI.Controllers;

namespace PI
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            CardFileController fileController = new CardFileController();
            fileController.Test1_Write();
            fileController.Test1_Read();
        }
    }
}
