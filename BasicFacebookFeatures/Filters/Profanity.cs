using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.Filters
{
    class Profanity : Filter
    {
        public virtual void handle(ref string i_Text)
        {
            i_Text = i_Text + "p";
            base.handle(ref i_Text);
        }
    }
}
