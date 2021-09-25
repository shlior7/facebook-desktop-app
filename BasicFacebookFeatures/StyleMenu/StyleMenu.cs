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
            initialize();
        }

        public ContextMenuStrip StyleContextMenu
        {
            get => m_StyleContextMenu;
        }

        public abstract void initialize();

        public abstract void changeBackColor(object sender, System.EventArgs e);

        public abstract void changeForeColor(object sender, System.EventArgs e);

        public abstract void changeHoverColor(object sender, System.EventArgs e);

        public abstract void changeFont(object sender, System.EventArgs e);

        public abstract void changeRandomStyle(object sender, System.EventArgs e);
    }
}
