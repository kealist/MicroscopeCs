using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MicroscopeLibrary;
using MicroscopeLibrary.Models;

namespace MicroscopeUI
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

            //Initialize DB connections
            GlobalConfig.InitializeConnections(true, false);

            Application.Run(new MicroscopeGameMenuForm());
        }
    }
}
