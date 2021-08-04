using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Clipboard.SetText("design.patterns20cc");
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login();
        }
        private static bool logout;

        private static void Login()
        {
            FormLogin login = new FormLogin();
            login.ShowDialog();
            if (login.LoggedInUser != null)
            {
                FormMain main = new FormMain(login.LoggedInUser);
                main.FormClosed += new FormClosedEventHandler(main_FormClosed);
                Application.Run(main);
                if (logout)
                    Login();
            }
            else
                Application.Exit();
        }

        static void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            logout = (sender as FormMain).Logout;
        }
    }
}
