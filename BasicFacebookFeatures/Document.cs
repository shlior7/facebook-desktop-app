using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    class Document
    {
        private ArrayList m_TextArray;
        public Document(string i_Document)
        {
            m_TextArray = new ArrayList();
            m_TextArray.AddRange(i_Document.Split(' '));
        }

        public void Write(string text)
        {
            m_TextArray.Add(text);
        }
        public void Erase(string text)
        {
            m_TextArray.Remove(text);
        }

        public void Replace(string oldText, string newText)
        {
            int oldTextsIndex = m_TextArray.IndexOf(oldText);
            if (oldTextsIndex >= 0)
            {
                m_TextArray[oldTextsIndex] = newText;
            }
        }

        public string ReadDocument()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (string text in m_TextArray)
                sb.Append(text);
            return sb.ToString();
        }
        public string CensorWord(string i_Word)
        {
            StringBuilder censoredWord = new StringBuilder();

            for (int i = 0; i < i_Word.Length; i++)
            {
                if (i == 0 || i == i_Word.Length - 1)
                {
                    censoredWord.Append(i_Word.ElementAt(i));
                }
                else
                {
                    censoredWord.Append('*');
                }
            }

            return censoredWord.ToString();
        }
    }
}
