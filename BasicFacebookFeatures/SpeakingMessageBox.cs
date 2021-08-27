using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public static class SpeakingMessageBox
    {
        public static void Show(string i_Message, string i_Caption = "", MessageBoxButtons i_MessageBoxButtons = MessageBoxButtons.OK)
        {
            MyAssistant m_Facy = MyAssistant.GetAssistantInstance;
            m_Facy.Speak(i_Message);
            MessageBox.Show(i_Message, i_Caption, i_MessageBoxButtons);
        }
    }
}
