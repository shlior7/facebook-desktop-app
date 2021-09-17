using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public interface IStylable
    {
        void changeForeColor(Color i_Color);
        void changeBackColor(Color i_Color);
        void changeHoverColor(Color i_Color);
        void setFontSize(int i_FontWidth, int i_FontHeight);
        Size getFontSize();
        void changeStyle();
        void setContextMenu(ContextMenuStrip i_ContextMenu);
    }
}
