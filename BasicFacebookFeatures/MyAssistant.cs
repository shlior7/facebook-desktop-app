using System.Speech.Synthesis;


namespace BasicFacebookFeatures
{
    public sealed class MyAssistant
    {
        private bool m_AuditoryAssistantOnOff;
        private SpeechSynthesizer m_Facy;
        private static MyAssistant s_Assitant;

        private MyAssistant()
        {
            m_Facy = new SpeechSynthesizer();
            m_Facy.SetOutputToDefaultAudioDevice();
        }

        public static MyAssistant GetAssistantInstance
        {
            get
            {
                if (s_Assitant == null)
                {
                    s_Assitant = new MyAssistant();
                }

                return s_Assitant;
            }
        }

        public bool AuditoryAssistant { get => m_AuditoryAssistantOnOff; set => m_AuditoryAssistantOnOff = value; }

        public void Speak(string i_Message)
        {
            if (m_Facy.State != SynthesizerState.Speaking && m_AuditoryAssistantOnOff)
            {
                m_Facy.Speak(i_Message);
            }
        }
    }
}
