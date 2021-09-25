using System;
using System.Drawing;

namespace BasicFacebookFeatures
{
    public class StyleImplementorLabel : IStylable
    {
        private StyledLabel m_Label;

        public StyleImplementorLabel(StyledLabel i_Label)
        {
            m_Label = i_Label;
        }

        public void PickBackColor()
        {
            FormColorPick pickColor = new FormColorPick();
            pickColor.ShowDialog();
            if (pickColor.Confirmed)
            {
                m_Label.BackColor = pickColor.ChosenColor;
            }
        }

        public void PickForeColor()
        {
            FormColorPick pickColor = new FormColorPick();
            pickColor.ShowDialog();
            if (pickColor.Confirmed)
            {
                m_Label.ForeColor = pickColor.ChosenColor;
            }
        }

        public void PickHoverColor()
        {
            FormColorPick pickColor = new FormColorPick();
            pickColor.ShowDialog();
            if (pickColor.Confirmed)
            {
                m_Label.HoverColor = pickColor.ChosenColor;
            }
        }

        public void PickFont()
        {
            FormFontPick pickFont = new FormFontPick(m_Label.Font);
            pickFont.ShowDialog();
            if (pickFont.Confirmed)
            {
                m_Label.Font = new Font(pickFont.FontFamily, m_Label.Font.Size, pickFont.FontStyle);
            }
        }

        public void RandomStyle()
        {
            Random random = new Random();
            m_Label.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), 0);
            m_Label.HoverColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), 0);
            m_Label.BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), 0);
        }
    }
}
