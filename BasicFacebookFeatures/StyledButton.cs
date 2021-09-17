﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace BasicFacebookFeatures
{
    public class StyledButton : Button, IStylable
    {
        private Color m_clearColor;
        private Color m_MainColor = Color.DarkSalmon;
        private Color m_Hovercolor = Color.DarkSalmon;
        private Color m_Clickcolor = Color.DarkSalmon;

        public Color BZBackColor
        {
            get
            {
                return m_MainColor;
            }

            set
            {
                m_MainColor = value;
            }
        }

        public Color MouseHoverColor
        {
            get
            {
                return m_Hovercolor;
            }

            set
            {
                m_Hovercolor = value;
            }
        }

        public Color MouseClickColor
        {
            get
            {
                return m_Clickcolor;
            }

            set
            {
                m_Clickcolor = value;
            }
        }

        public StyledButton()
        {
            this.BackColor = Color.DarkSalmon;
            this.FlatStyle = FlatStyle.Flat;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            m_clearColor = m_MainColor;
            m_MainColor = m_Hovercolor;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            m_MainColor = m_clearColor;
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            m_MainColor = m_Clickcolor;
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            m_MainColor = m_clearColor;
        }

        private GraphicsPath GetRoundPath(RectangleF i_Rect, int i_Radius)
        {
            float halfRadius = i_Radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();
            GraphPath.AddArc(i_Rect.X, i_Rect.Y, i_Radius, i_Radius, 180, 90);
            GraphPath.AddLine(i_Rect.X + halfRadius, i_Rect.Y, i_Rect.Width - halfRadius, i_Rect.Y);
            GraphPath.AddArc(i_Rect.X + i_Rect.Width - i_Radius, i_Rect.Y, i_Radius, i_Radius, 270, 90);
            GraphPath.AddLine(i_Rect.Width, i_Rect.Y + halfRadius, i_Rect.Width, i_Rect.Height - halfRadius);
            GraphPath.AddArc(i_Rect.X + i_Rect.Width - i_Radius, i_Rect.Y + i_Rect.Height - i_Radius, i_Radius, i_Radius, 0, 90);
            GraphPath.AddLine(i_Rect.Width - halfRadius, i_Rect.Height, i_Rect.X + halfRadius, i_Rect.Height);
            GraphPath.AddArc(i_Rect.X, i_Rect.Y + i_Rect.Height - i_Radius, i_Radius, i_Radius, 90, 90);
            GraphPath.AddLine(i_Rect.X, i_Rect.Height - halfRadius, i_Rect.X, i_Rect.Y + halfRadius);
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

        public void changeForeColor(Color i_Color)
        {
            this.ForeColor = i_Color;
        }

        public void changeBackColor(Color i_Color)
        {
            m_MainColor = i_Color;
        }

        public void changeHoverColor(Color i_Color)
        {
            m_Hovercolor = i_Color;
        }

        public void setFontSize(int i_FontWidth, int i_FontHeight)
        {
            this.Size = new Size(i_FontWidth, i_FontHeight);
        }

        public void changeStyle()
        {
            Random r = new Random();
            this.ForeColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);
            m_Hovercolor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);
            m_MainColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);
            m_Clickcolor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);
        }

        public void setContextMenu(ContextMenuStrip i_ContextMenu)
        {
            this.ContextMenuStrip = i_ContextMenu;
        }
        public Size getFontSize()
        {
            return this.Size;
        }
    }
}