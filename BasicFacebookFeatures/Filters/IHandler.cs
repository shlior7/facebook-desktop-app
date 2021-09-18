using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    interface IHandler
    {
        void setNextHandler(IHandler i_NextHandler);
        void handle(ref string i_Text);
    }
}
