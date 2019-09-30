using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLData;

namespace Project_QLDSV
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

            DSSV dSSV = new DSSV(100);
            dSSV.Add(new Student("A"));
            dSSV.Add(new Student("B"));
            dSSV.Add(new Student("C"));
            dSSV.Add(new Student("D"));
            dSSV.Remove(new Student("C"));
            dSSV.Add(new Student("E"));
            dSSV.Current
        }
    }
}
