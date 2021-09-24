using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class StyleMenu
    {
        private IStylable m_StylableElement;

        public StyleMenu(IStylable i_StylableElement)
        {
            m_StylableElement = i_StylableElement;
            initialize();
        }
        private void initialize()
        {
            ContextMenuStrip styleMenu = new ContextMenuStrip();
            ToolStripMenuItem colorChangeSubMenu = new ToolStripMenuItem();
            colorChangeSubMenu.Text = "Change Color";
            colorChangeSubMenu.DropDownItems.Add("Background Color", null, changeBackColor);
            colorChangeSubMenu.DropDownItems.Add("Text Color", null, changeForeColor);
            colorChangeSubMenu.DropDownItems.Add("Hover Color", null, changeHoverColor);
            styleMenu.Items.Add(colorChangeSubMenu);
            styleMenu.Items.Add("Change Font", null, changeFont);
            styleMenu.Items.Add("Random Style", null, changeRandomStyle);
            m_StylableElement.ContextMenuStrip = styleMenu;
        }
        private void changeBackColor(object sender, System.EventArgs e)
        {
            FormColorPick pickColor = new FormColorPick();
            pickColor.ShowDialog();
            if (pickColor.Confirmed)
            {
                m_StylableElement.BackColor = pickColor.ChosenColor;
            }
        }
        private void changeForeColor(object sender, System.EventArgs e)
        {
            FormColorPick pickColor = new FormColorPick();
            pickColor.ShowDialog();
            if (pickColor.Confirmed)
            {
                m_StylableElement.ForeColor = pickColor.ChosenColor;
            }
        }
        private void changeHoverColor(object sender, System.EventArgs e)
        {
            FormColorPick pickColor = new FormColorPick();
            pickColor.ShowDialog();
            if (pickColor.Confirmed)
            {
                m_StylableElement.HoverColor = pickColor.ChosenColor;
            }
        }

        private void changeFont(object sender, System.EventArgs e)
        {

            FormFontPick pickFont = new FormFontPick(m_StylableElement.Font);
            pickFont.ShowDialog();
            if (pickFont.Confirmed)
            {
                m_StylableElement.Font = new Font(pickFont.FontFamily, m_StylableElement.Font.Size, pickFont.FontStyle);
            }
        }

        private void changeRandomStyle(object sender, System.EventArgs e)
        {
            m_StylableElement.setRandomStyle();
        }
    }
}
