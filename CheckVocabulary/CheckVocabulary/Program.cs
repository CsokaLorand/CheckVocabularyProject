﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckVocabulary
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


            Application.Run(new Form1());

            //new Thread(() =>
            //{
            //    while (true)
            //    {
            //        Thread.Sleep(10000);

            //        Application.Run(new Form1());
            //    }
            //}).Start();
        }
    }
}
