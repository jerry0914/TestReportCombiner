﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace com.usi.shd1_tools.TestReportCombiner
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
            Application.Run(new FormMain());
        }
    }
}
