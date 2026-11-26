using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Speed_Converter
{
    static class Program
    {
        /// <summary>
        /// 應用程式的進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
