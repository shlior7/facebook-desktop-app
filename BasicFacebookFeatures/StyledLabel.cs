using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class StyledLabel : Label
    {
        private Color m_clearColor;
        private Color m_Hovercolor = Color.Gray;

        public StyledLabel()
        {
            this.BackColor = System.Drawing.Color.Transparent;
        }

        public void EnableStyleMenu()
        {
            StyleMenuLabel StyleMenu = new StyleMenuLabel(new StyleImplementorLabel(this));
            this.ContextMenuStrip = StyleMenu.StyleContextMenu;
        }

        public Color HoverColor
        {
            get => m_Hovercolor;
            set => m_Hovercolor = value;
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
    }
}