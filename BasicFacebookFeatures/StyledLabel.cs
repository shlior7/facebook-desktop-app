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
        StyleMenu m_StyleMenu;

        public StyledLabel()
        {
            this.BackColor = System.Drawing.Color.Transparent;
            m_StyleMenu = new StyleMenu(new StyleImplementorLabel(this));
        }

        public StyledLabel(bool i_EnableStyleMenu)
        {
            this.BackColor = System.Drawing.Color.Transparent;
            if (i_EnableStyleMenu)
            {
                m_StyleMenu = new StyleMenu(new StyleImplementorLabel(this));
            }
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


        public void setRandomStyle()
        {
            Random random = new Random();
            ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), 0);
            m_Hovercolor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), 0);
            BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), 0);
        }
    }
}
