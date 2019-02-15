using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vtdi_gatelog_b
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
            var parent = new Form1();
            parent.IsMdiContainer = true;
            var login = new LogInForm();
            login.MdiParent = parent;
            Application.Run(parent);
            Application.Run(login);
        }
    }
}
