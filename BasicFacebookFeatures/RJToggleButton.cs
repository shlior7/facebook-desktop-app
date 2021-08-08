using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace BasicFacebookFeatures
{
    public class RJToggleButton : CheckBox
    {
        private Color onBackColor = Color.Green;
        private Color onToggleColor = Color.WhiteSmoke;
        private Color offBackColor = Color.Gray;
        private Color offToggleColor = Color.Gainsboro;
        private bool solidStyle = true;

        public RJToggleButton()
        {
            this.BackColor = Color.White;
        }

        private GraphicsPath GetFigurePath()
        {
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs paintEvent)
        {
            int toggleSize = this.Height - 5;
            paintEvent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            paintEvent.Graphics.Clear(this.Parent.BackColor);

            if (this.Checked) 
            {
                if (solidStyle)
                {
                    paintEvent.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePath());
                }
                else
                {
                    paintEvent.Graphics.DrawPath(new Pen(onBackColor, 2), GetFigurePath());
                }

                paintEvent.Graphics.FillEllipse(new SolidBrush(onToggleColor), new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize));
            }
            else 
            {
                if (solidStyle)
                {
                    paintEvent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());
                }
                else
                {
                    paintEvent.Graphics.DrawPath(new Pen(offBackColor, 2), GetFigurePath());
                }

                paintEvent.Graphics.FillEllipse(new SolidBrush(offToggleColor), new Rectangle(2, 2, toggleSize, toggleSize));
            }
        }
    }
}
