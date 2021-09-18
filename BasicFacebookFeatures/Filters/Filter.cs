using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.Filters
{
    class Filter : IHandler
    {
        private IHandler m_NextHandler;

        public virtual void handle(ref string i_Text)
        {
            if (m_NextHandler != null)
            {
                m_NextHandler.handle(ref i_Text);
            }
        }

        public void setNextHandler(IHandler i_NextHandler)
        {
            m_NextHandler = i_NextHandler;
        }
    }
}
