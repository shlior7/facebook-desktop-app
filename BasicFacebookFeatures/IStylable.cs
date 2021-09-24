using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public interface IStylable
    {
        Color ForeColor { get; set; }
        Color BackColor { get; set; }

        Color HoverColor { get; set; }
        Font Font { get; set; }
        string Text { get; }
        ContextMenuStrip ContextMenuStrip { set; }
        void setRandomStyle();
    }
}
