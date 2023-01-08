using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMTPer
{
    internal static class Program
    {
        internal static Form FormMain;
        /// <summary>应用程序的主入口点。</summary>
        [STAThread]
        internal static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormMain = new WinMain();
            Application.Run(FormMain);
        }
    }
}
