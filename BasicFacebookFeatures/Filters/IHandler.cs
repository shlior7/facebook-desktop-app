using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public interface IHandler
    {
        void setNextHandler(IHandler i_NextHandler);
        void Handle(Document i_Text);
    }
}
