using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoForm_gh26032021
{
    static class Program
    {
        public static FormConfig formConfig = null;
        public static FormLogin formLogin = null;
        public static FormMain formMain = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formConfig = new FormConfig();
            Application.Run(formConfig);
        }
    }
}
