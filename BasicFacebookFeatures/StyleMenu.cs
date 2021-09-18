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
        public IStylable m_StylableElement;
        public ContextMenuStrip m_StyleMenu;

        public StyleMenu(IStylable i_StylableElement)
        {
            m_StylableElement = i_StylableElement;
            m_StyleMenu = new ContextMenuStrip();

            ToolStripMenuItem colorChangeSubMenu = new ToolStripMenuItem();
            colorChangeSubMenu.Text = "Change Color";
            colorChangeSubMenu.DropDownItems.Add("Background Color", null, ChangeBackColor);
            colorChangeSubMenu.DropDownItems.Add("Text Color", null, changeForeColor);
            colorChangeSubMenu.DropDownItems.Add("Hover Color", null, changeHoverColor);
            m_StyleMenu.Items.Add(colorChangeSubMenu);
            m_StyleMenu.Items.Add("Change Font", null, changeFont);
            m_StyleMenu.Items.Add("Random Style", null, changeRandomStyle);
            m_StylableElement.setContextMenu(m_StyleMenu);
        }

        private void ChangeBackColor(object sender, System.EventArgs e)
        {
            FormColorPick pickColor = new FormColorPick();
            pickColor.ShowDialog();
            if (pickColor.Confirmed)
            {
                m_StylableElement.setBackColor(pickColor.ChosenColor);
            }
        }
        private void changeForeColor(object sender, System.EventArgs e)
        {
            FormColorPick pickColor = new FormColorPick();
            pickColor.ShowDialog();
            if (pickColor.Confirmed)
            {
                m_StylableElement.setForeColor(pickColor.ChosenColor);
            }
        }
        private void changeHoverColor(object sender, System.EventArgs e)
        {
            FormColorPick pickColor = new FormColorPick();
            pickColor.ShowDialog();
            if (pickColor.Confirmed)
            {
                m_StylableElement.setHoverColor(pickColor.ChosenColor);
            }
        }

        private void changeFont(object sender, System.EventArgs e)
        {
            m_StylableElement.getFont();
        }

        private void changeRandomStyle(object sender, System.EventArgs e)
        {
            m_StylableElement.setRandomStyle();
        }
    }
}
