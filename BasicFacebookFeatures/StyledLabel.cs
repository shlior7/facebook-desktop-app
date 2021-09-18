using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    class StyledLabel : Label, IStylable
    {
        private Color m_clearColor;
        private Color m_Hovercolor = Color.Gray;

        public StyledLabel()
        {
            this.BackColor = System.Drawing.Color.Transparent;
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            m_clearColor = this.ForeColor;
            this.ForeColor = m_Hovercolor;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.ForeColor = m_clearColor;
        }

        public void setBackColor(Color i_Color)
        {
            BackColor = i_Color;
        }
        public void setHoverColor(Color i_Color)
        {
            m_Hovercolor = i_Color;
        }

        public void setForeColor(Color i_Color)
        {
            ForeColor = i_Color;
        }

        public void setRandomStyle()
        {
            Random random = new Random();
            ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), 0);
            m_Hovercolor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), 0);
            BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), 0);
        }

        public void setFont(string i_FontFamily, FontStyle i_FontStyle)
        {
            this.Font = new System.Drawing.Font(i_FontFamily, this.Font.Size, i_FontStyle);
        }

        public void setContextMenu(ContextMenuStrip i_ContextMenu)
        {
            this.ContextMenuStrip = i_ContextMenu;
        }
        public Font getFont()
        {
            return this.Font;
        }
    }
}
