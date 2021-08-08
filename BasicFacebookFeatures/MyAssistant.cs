using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public sealed class MyAssistant
    {
        private static SpeechSynthesizer s_Facy;
        private static MyAssistant s_Assitant;
        private bool m_AuditoryAssistant;

        private SpeechSynthesizer Facy 
        {
            get => s_Facy; 
        }

        private MyAssistant()
        {
            s_Facy = new SpeechSynthesizer();
            s_Facy.SetOutputToDefaultAudioDevice();
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

        public bool AuditoryAssistant { get => m_AuditoryAssistant; set => m_AuditoryAssistant = value; }

        public void Speak(string i_Message)
        {
            if (Facy.State != SynthesizerState.Speaking && m_AuditoryAssistant)
            {
                Facy.Speak(i_Message);
            }
        }
    }
}
