using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace callXBFLibrary
{
    static class CallXBFLib
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmCall_XBF());
        }
    }
}