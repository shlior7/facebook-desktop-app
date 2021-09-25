using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class StyleMenuLabel : StyleMenu
    {
        public StyleMenuLabel(IStylable i_StylableElement) : base(i_StylableElement)
        {
            initialize();
        }

        public override void initialize()
        {
            m_StyleContextMenu = new ContextMenuStrip();
            ToolStripMenuItem colorChangeSubMenu = new ToolStripMenuItem();
            colorChangeSubMenu.Text = "Change Text Color";
            colorChangeSubMenu.DropDownItems.Add("Background Color", null, changeBackColor);
            colorChangeSubMenu.DropDownItems.Add("Text Color", null, changeForeColor);
            colorChangeSubMenu.DropDownItems.Add("Hover Color", null, changeHoverColor);
            m_StyleContextMenu.Items.Add(colorChangeSubMenu);
            m_StyleContextMenu.Items.Add("Change Text Font", null, changeFont);
            m_StyleContextMenu.Items.Add("Random Style", null, changeRandomStyle);
        }

        public override void changeBackColor(object sender, System.EventArgs e)
        {
            m_StylableElement.PickBackColor();
        }

        public override void changeForeColor(object sender, System.EventArgs e)
        {
            m_StylableElement.PickForeColor();
        }

        public override void changeHoverColor(object sender, System.EventArgs e)
        {
            m_StylableElement.PickHoverColor();
        }

        public override void changeFont(object sender, System.EventArgs e)
        {
            m_StylableElement.PickFont();
        }

        public override void changeRandomStyle(object sender, System.EventArgs e)
        {
            m_StylableElement.setRandomStyle();
        }
    }
}
