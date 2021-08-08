using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public static class FacebookRunner
    {
        private static bool s_logout;

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
                if (s_logout)
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
            s_logout = (sender as FormMain).Logout;
        }
    }
}
