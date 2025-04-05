using System;
using System.Windows.Forms;

namespace Dating_app
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            const string connectionString = @"Data Source=DESKTOP-39AHLS4;Initial Catalog=Dating_app_base;Integrated Security=True";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainFormLogin(connectionString));
            Application.Run(new MainForm(1, connectionString));
        }
    }
}