namespace BasicFacebookFeatures
{
    public struct PastUser
    {
        public string m_Name;
        public string m_AccessToken;

        public PastUser(string i_Name, string i_AccessToken)
        {
            m_Name = i_Name;
            m_AccessToken = i_AccessToken;
        }
    }
}
