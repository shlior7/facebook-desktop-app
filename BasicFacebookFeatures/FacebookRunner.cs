using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public static class FacebookRunner
    {
        private static bool s_logout;
        private static FormLogin s_LoginForm;

        public static void Login()
        {
            s_LoginForm = new FormLogin();
            s_LoginForm.StartPosition = FormStartPosition.CenterScreen;
            s_LoginForm.ShowDialog();
            if (s_LoginForm.LoggedInUser != null)
            {
                FormMain mainForm = new FormMain(s_LoginForm.LoggedInUser);
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

        private static void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            s_logout = (sender as FormMain).Logout;
        }
    }
}
