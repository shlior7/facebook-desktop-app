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
            get => m_LoggedInUser;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns.c21"); /// the current password for Desig Patter
            loginAndInit();
        }

        private void loginAndInit()
        {
            string access = "EAAFSD8o8IEMBAISQ5uT9cXYlXStEPBRWIbdyRbLYLODCgINiSPMMV9bl6Gq6FJIsD0iwMIUZAra12CxRZA89HmS27v4KBqR6QWgBWWl4BEGb2PH4kK5iDGnC716cOICPOZB6lYZC6bvZCkBX2d9xiUWw88lPAkpwyEvhQqpRZAZCgZDZD";
            LoginResult m_LoginResult = FacebookService.Connect(access); 
            /*
            LoginResult m_LoginResult = FacebookService.Login("371702747635779", /// (desig patter's "Design Patterns Course App 2.4" app)
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
              );*/
            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
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
