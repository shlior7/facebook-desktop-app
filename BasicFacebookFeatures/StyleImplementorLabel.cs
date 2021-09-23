using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class StyleImplementorLabel : IStylable
    {
        StyledLabel m_Label;
        public StyleImplementorLabel(StyledLabel i_Label)
        {
            m_Label = i_Label;
        }

        public Color ForeColor { get => m_Label.ForeColor; set => m_Label.ForeColor = value; }
        public Color BackColor { get => m_Label.BackColor; set => m_Label.BackColor = value; }
        public Color HoverColor { get => m_Label.HoverColor; set => m_Label.HoverColor = value; }
        public Font Font { get => m_Label.Font; set => m_Label.Font = value; }
        public string Text => m_Label.Text;
        public ContextMenuStrip ContextMenuStrip { set => m_Label.ContextMenuStrip = value; }
        public void setRandomStyle()
        {
            Random random = new Random();
            ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), 0);
            HoverColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), 0);
            BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), 0);
        }
    }
}
