using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormLogin : Form
    {
        private User m_LoggedInUser;
        private string m_AccessToken;

        public FormLogin()
        {
            m_AccessToken = string.Empty;
            InitializeComponent();
        }

        public User LoggedInUser
        {
            get => m_LoggedInUser;
        }

        public string AccessToken { get => m_AccessToken; }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns21c"); /// the current password for Desig Patter
            loginAndInit();
        }

        private void loginAndInit()
        {
            string access = "EAAFSD8o8IEMBAAJ8uQFJS8Sw2xmki97LIpus3OqzbHBSw0JYNVWH3f2g0Gaed1DMoeZBZAclmmpuvNMdJ6SmSMKkW2UhzHoQOklCFbM3Os1JMjou87ZBZC5ULNy1CbxWr4SS0VJpx8REZBwIE5jH11QmuQZAk1ffpXYIMVeeIDdQZDZD";
            LoginResult m_LoginResult = FacebookService.Connect(access);
            /*LoginResult m_LoginResult = FacebookService.Login("371702747635779", /// (desig patter's "Design Patterns Course App 2.4" app)
					"email",
                    "public_profile",
                    "user_age_range",
                    "user_birthday",
                    "user_events",
                    "user_friends",
                    "user_gender",
                    "user_hometown",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_videos"
              );
            */
            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                if (SaveUserCheckBox.Checked)
                {
                    m_AccessToken = m_LoginResult.AccessToken;
                }

                m_LoggedInUser = m_LoginResult.LoggedInUser;
                string s = m_LoginResult.AccessToken;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
        }
    }
}
