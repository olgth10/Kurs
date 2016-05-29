using System;
using System.Windows.Forms;
using Kurs.Forms.Actual;

namespace Kurs
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ListCR());
        }
    }
}
