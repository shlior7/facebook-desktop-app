using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class StyleImplementorButton : IStylable
    {
        private StyledButton m_Button;

        public StyleImplementorButton(StyledButton i_Button)
        {
            m_Button = i_Button;
        }

        public Color ForeColor { get => m_Button.ForeColor; set => m_Button.ForeColor = value; }

        public Color BackColor { get => m_Button.BackColor; set => m_Button.BackColor = value; }

        public Color HoverColor { get => m_Button.HoverColor; set => m_Button.HoverColor = value; }

        public Font Font { get => m_Button.Font; set => m_Button.Font = value; }

        public string Text => m_Button.Text;

        public ContextMenuStrip ContextMenuStrip { set => m_Button.ContextMenuStrip = value; }

        public void setRandomStyle()
        {
            Random r = new Random();
            ForeColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);
            HoverColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);
            BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);
            m_Button.MouseClickColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);
        }
    }
}
