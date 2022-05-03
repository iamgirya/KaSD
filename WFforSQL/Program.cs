using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WFforSQL
{
    static class Program
    {
        public static MainForm MainForm;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm = new MainForm();
            Application.Run(MainForm);
        }
    }
}
