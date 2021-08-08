using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace BasicFacebookFeatures
{
    public class StyledButton : System.Windows.Forms.Button
    {
        private Color clr1;
        private Color color = Color.DarkSalmon;
        private Color m_hovercolor = Color.DarkSalmon;
        private Color clickcolor = Color.DarkSalmon;
        private string text = "_";

        public string DisplayText
        {
            get 
            {
                return text; 
            }

            set 
            { 
                text = value;
                Invalidate(); 
            }
        }

        public Color BZBackColor
        {
            get 
            {
                return color; 
            }

            set 
            { 
                color = value; 
                Invalidate();
            }
        }

        public Color MouseHoverColor
        {
            get 
            {
                return m_hovercolor; 
            }

            set
            {
                m_hovercolor = value; 
                Invalidate(); 
            }
        }

        public Color MouseClickColor1
        {
            get 
            { 
                return clickcolor;
            }

            set 
            {
                clickcolor = value; 
                Invalidate(); 
            }
        }

        public StyledButton()
        {
            this.BackColor = Color.DarkSalmon;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            clr1 = color;
            color = m_hovercolor;
        }

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

        private GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float r2 = radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();
            GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);
            GraphPath.CloseFigure();
            return GraphPath;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            using (GraphicsPath GraphPath = GetRoundPath(Rect, 50))
            {
                this.Region = new Region(GraphPath);
                using (Pen pen = new Pen(Color.DarkSalmon, 1.75f))
                {
                    pen.Alignment = PenAlignment.Inset;
                    e.Graphics.DrawPath(pen, GraphPath);
                }
            }
        }
    }
}