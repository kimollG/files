using System;
using System.Collections.Generic;
using System.Linq;
////using System.Threading.Tasks;not support in 3.5 .Netnot support in 3.5 .Net
using System.Windows.Forms;

namespace Semestr2Att3
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
            Application.Run(new Form34());
        }
    }
}
