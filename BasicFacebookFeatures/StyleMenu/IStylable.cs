using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public interface IStylable
    {
        void PickBackColor();

        void PickForeColor();

        void PickHoverColor();

        void PickFont();

        void setRandomStyle();
    }
}
