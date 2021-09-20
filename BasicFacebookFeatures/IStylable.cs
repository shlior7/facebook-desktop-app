﻿using System;
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
        Color ForeColor { get; set; }
        Color BackColor { get; set; }

        Color HoverColor { get; set; }
        Font Font { get; set; }
        string Text { get; }
        ContextMenuStrip ContextMenuStrip { set; }
        void setRandomStyle();

        //void setForeColor(Color i_Color);
        //void setBackColor(Color i_Color);
        //void setHoverColor(Color i_Color);
        //void setFont(string i_FontFamily, FontStyle i_FontStyle);
        //Font getFont();
        //string getText();
        //void setContextMenu(ContextMenuStrip i_ContextMenu);
    }
}
