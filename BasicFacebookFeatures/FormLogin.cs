using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormLogin : Form
    {
        private User m_LoggedInUser;

        public FormLogin()
        {
            InitializeComponent();
        }

        public User LoggedInUser
        {
            get
            {
                return m_LoggedInUser;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns21c"); /// the current password for Desig Patter
            loginAndInit();
        }

        private void loginAndInit()
        {
            string access = "EAAFSD8o8IEMBAC9Ip6EAGVAAZAbDQu6fVRVRKnKd1TiZAyf49Bpj6ZBaILzh1cdBMjyZAZCBXRLUTZBN7Ax4Dlghwe47LKOGDGjM5T425RDh651WqBTmhdyeryAUAoKCyZA9dhy1CVdjocihdMZAyKGnjuPLEvuWLOAwQxLslEscXQZDZD";
            LoginResult m_LoginResult = FacebookService.Connect(access);
            /*m_LoginResult = FacebookService.Login("371702747635779", /// (desig patter's "Design Patterns Course App 2.4" app)
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
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                string s = m_LoginResult.AccessToken;
                this.DialogResult = DialogResult.OK;
                buttonLogin.Text = $"Logged in as{m_LoginResult.LoggedInUser.Name}";
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
