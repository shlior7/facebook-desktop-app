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

        public void changeBackColor(Color i_Color)
        {
            BackColor = i_Color;
        }
        public void changeHoverColor(Color i_Color)
        {
            m_Hovercolor = i_Color;
        }

        public void changeForeColor(Color i_Color)
        {
            ForeColor = i_Color;
        }

        public void changeStyle()
        {
            Random r = new Random();
            ForeColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);
            m_Hovercolor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);
            BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);
        }
        public Size getFontSize()
        {
            return this.Size;
        }

        public void setFontSize(int i_FontWidth, int i_FontHeight)
        {
            this.Size = new System.Drawing.Size(i_FontWidth, i_FontHeight);
        }

        public void setContextMenu(ContextMenuStrip i_ContextMenu)
        {
            this.ContextMenuStrip = i_ContextMenu;
        }
    }
}
