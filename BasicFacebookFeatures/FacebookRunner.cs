using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class FacebookRunner
    {
        private static bool s_logout;
        private static FormLogin m_LoginForm;

        public static void Login()
        {
            m_LoginForm = new FormLogin();
            m_LoginForm.StartPosition = FormStartPosition.CenterScreen;
            m_LoginForm.ShowDialog();
            if (m_LoginForm.LoggedInUser != null)
            {
                FormMain mainForm = new FormMain(m_LoginForm.LoggedInUser);
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

        public static User getConnectedUser()
        {
            return m_LoginForm.LoggedInUser;
        }

        private static void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            s_logout = (sender as FormMain).Logout;
        }
    }
}
