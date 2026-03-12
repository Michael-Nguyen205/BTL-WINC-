using System;
using System.Windows.Forms;

namespace StudentManagement
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            LoginForm loginForm = new LoginForm();

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new StudentListForm());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
