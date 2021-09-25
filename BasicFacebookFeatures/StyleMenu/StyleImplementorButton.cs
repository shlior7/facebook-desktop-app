using System;
using System.Drawing;

namespace BasicFacebookFeatures
{
    public class StyleImplementorButton : IStylable
    {
        private StyledButton m_Button;

        public StyleImplementorButton(StyledButton i_Button)
        {
            m_Button = i_Button;
        }

        public void PickBackColor()
        {
            FormColorPick pickColor = new FormColorPick();
            pickColor.ShowDialog();
            if (pickColor.Confirmed)
            {
                m_Button.BackColor = pickColor.ChosenColor;
            }
        }

        public void PickForeColor()
        {
            FormColorPick pickColor = new FormColorPick();
            pickColor.ShowDialog();
            if (pickColor.Confirmed)
            {
                m_Button.ForeColor = pickColor.ChosenColor;
            }
        }

        public void PickHoverColor()
        {
            FormColorPick pickColor = new FormColorPick();
            pickColor.ShowDialog();

            if (pickColor.Confirmed)
            {
                m_Button.HoverColor = pickColor.ChosenColor;
            }
        }

        public void PickFont()
        {
            FormFontPick pickFont = new FormFontPick(m_Button.Font);
            pickFont.ShowDialog();

            if (pickFont.Confirmed)
            {
                m_Button.Font = new Font(pickFont.FontFamily, m_Button.Font.Size, pickFont.FontStyle);
            }
        }

        public void RandomStyle()
        {
            Random r = new Random();
            m_Button.ForeColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);
            m_Button.HoverColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);
            m_Button.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);
            m_Button.MouseClickColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);
        }
    }
}
