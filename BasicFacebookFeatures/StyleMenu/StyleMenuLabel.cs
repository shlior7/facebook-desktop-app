using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class StyleMenuLabel : StyleMenu
    {
        public StyleMenuLabel(IStylable i_StylableElement) : base(i_StylableElement)
        {
            Initialize();
        }

        public override void Initialize()
        {
            m_StyleContextMenu = new ContextMenuStrip();
            ToolStripMenuItem colorChangeSubMenu = new ToolStripMenuItem();
            colorChangeSubMenu.Text = "Change Text Color";
            colorChangeSubMenu.DropDownItems.Add("Background Color", null, ChangeBackColor);
            colorChangeSubMenu.DropDownItems.Add("Text Color", null, ChangeForeColor);
            colorChangeSubMenu.DropDownItems.Add("Hover Color", null, ChangeHoverColor);
            m_StyleContextMenu.Items.Add(colorChangeSubMenu);
            m_StyleContextMenu.Items.Add("Change Text Font", null, ChangeFont);
            m_StyleContextMenu.Items.Add("Random Style", null, RandomStyle);
        }

        public override void ChangeBackColor(object sender, System.EventArgs e)
        {
            m_StylableElement.PickBackColor();
        }

        public override void ChangeForeColor(object sender, System.EventArgs e)
        {
            m_StylableElement.PickForeColor();
        }

        public override void ChangeHoverColor(object sender, System.EventArgs e)
        {
            m_StylableElement.PickHoverColor();
        }

        public override void ChangeFont(object sender, System.EventArgs e)
        {
            m_StylableElement.PickFont();
        }

        public override void RandomStyle(object sender, System.EventArgs e)
        {
            m_StylableElement.RandomStyle();
        }
    }
}
