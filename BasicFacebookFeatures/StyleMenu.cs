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
            ToolStripMenuItem fontSizeSubMenu = new ToolStripMenuItem();
            fontSizeSubMenu.Text = "Font Size";
            fontSizeSubMenu.DropDownItems.Add("Increase Font Size", null, increaseFontSize);
            fontSizeSubMenu.DropDownItems.Add("Decrease Font Size", null, decreaseFontSize);
            ToolStripMenuItem colorChangeSubMenu = new ToolStripMenuItem();
            colorChangeSubMenu.Text = "Color Change";
            colorChangeSubMenu.DropDownItems.Add("Background Color", null, ChangeBackColor);
            colorChangeSubMenu.DropDownItems.Add("Text Color", null, changeForeColor);
            colorChangeSubMenu.DropDownItems.Add("Hover Color", null, changeHoverColor);
            m_StyleMenu.Items.Add(colorChangeSubMenu);
            m_StyleMenu.Items.Add(fontSizeSubMenu);
            m_StyleMenu.Items.Add("Random Style", null, changeRandomStyle);
            m_StylableElement.setContextMenu(m_StyleMenu);
        }
        private void ChangeBackColor(object sender, System.EventArgs e)
        {
            FormColorPick pickColor = new FormColorPick();
            pickColor.ShowDialog();
            if (pickColor.Confirmed)
            {
                m_StylableElement.changeBackColor(pickColor.ChosenColor);
            }
        }
        private void changeForeColor(object sender, System.EventArgs e)
        {
            FormColorPick pickColor = new FormColorPick();
            pickColor.ShowDialog();
            if (pickColor.Confirmed)
            {
                m_StylableElement.changeForeColor(pickColor.ChosenColor);
            }
        }
        private void changeHoverColor(object sender, System.EventArgs e)
        {
            FormColorPick pickColor = new FormColorPick();
            pickColor.ShowDialog();
            if (pickColor.Confirmed)
            {
                m_StylableElement.changeHoverColor(pickColor.ChosenColor);
            }
        }
        private void increaseFontSize(object sender, System.EventArgs e)
        {
            Size currentSize = m_StylableElement.getFontSize();
            m_StylableElement.setFontSize(currentSize.Width + 2, currentSize.Height + 2);
        }
        private void decreaseFontSize(object sender, System.EventArgs e)
        {
            Size currentSize = m_StylableElement.getFontSize();
            m_StylableElement.setFontSize(currentSize.Width - 2, currentSize.Height - 2);
        }
        private void changeRandomStyle(object sender, System.EventArgs e)
        {
            m_StylableElement.changeStyle();
        }
    }
}
