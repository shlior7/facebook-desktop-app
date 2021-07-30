using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class StyledButton : System.Windows.Forms.Button
    {
        Color clr1;
        private Color color = Color.Teal;
        private Color m_hovercolor = Color.FromArgb(0, 0, 140);
        private Color clickcolor = Color.FromArgb(160, 180, 200);
        private String text = "_";

        public String DisplayText
        {
            get { return text; }
            set { text = value; Invalidate(); }
        }
        public Color BZBackColor
        {
            get { return color; }
            set { color = value; Invalidate(); }
        }

        public Color MouseHoverColor
        {
            get { return m_hovercolor; }
            set { m_hovercolor = value; Invalidate(); }
        }

        public Color MouseClickColor1
        {
            get { return clickcolor; }
            set { clickcolor = value; Invalidate(); }
        }


        public StyledButton()
        {
            this.BackColor = Color.Teal;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        }
        //method mouse enter 

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            clr1 = color;
            color = m_hovercolor;
        }
        //method mouse leave  
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            color = clr1;
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            color = clickcolor;
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            color = clr1;
        }


        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            //pe.Graphics.FillRectangle(new SolidBrush(color), ClientRectangle);
        }
    }
}