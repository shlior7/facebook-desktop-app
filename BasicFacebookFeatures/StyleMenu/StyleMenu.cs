using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public abstract class StyleMenu
    {
        protected IStylable m_StylableElement;
        protected ContextMenuStrip m_StyleContextMenu;

        public StyleMenu(IStylable i_StylableElement)
        {
            m_StylableElement = i_StylableElement;
            Initialize();
        }

        public ContextMenuStrip StyleContextMenu
        {
            get => m_StyleContextMenu;
        }

        public abstract void Initialize();

        public abstract void ChangeBackColor(object sender, System.EventArgs e);

        public abstract void ChangeForeColor(object sender, System.EventArgs e);

        public abstract void ChangeHoverColor(object sender, System.EventArgs e);

        public abstract void ChangeFont(object sender, System.EventArgs e);

        public abstract void RandomStyle(object sender, System.EventArgs e);
    }
}
