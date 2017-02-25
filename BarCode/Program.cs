﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarCode
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new BarCodeForm());
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.StackTrace, "Exception", MessageBoxButtons.OK);
            }
        }
    }
}
