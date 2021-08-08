using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    class FacebookRunner
    {
        private static bool logout;

        public static void Login()
        {
            FormLogin loginForm = new FormLogin();
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.ShowDialog();
            if (loginForm.LoggedInUser != null)
            {
                FormMain mainForm = new FormMain(loginForm.LoggedInUser);
                mainForm.FormClosed += new FormClosedEventHandler(main_FormClosed);
                Application.Run(mainForm);
                if (logout)
                {
                    Login();
                }
            }
            else
            {
                Application.Exit();
            }
        }

        public static void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            logout = (sender as FormMain).Logout;
        }
    }
}
