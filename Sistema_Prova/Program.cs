﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 

using System.Windows.Forms;

namespace Sistema_Prova
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
            Application.Run(new Sistema_Prova.Sistema.frmLogin());

          //  Application.Run(new Form1());


        }
    }
}
