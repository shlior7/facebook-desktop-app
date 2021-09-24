using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicFacebookFeatures.CommandPattern;

namespace BasicFacebookFeatures.Filters
{
    public class Filter : IHandler
    {
        protected IHandler m_NextHandler;

        public virtual void Handle(Document i_Text)
        {
            if (m_NextHandler != null)
            {
                m_NextHandler.Handle(i_Text);
            }
        }

        public void setNextHandler(IHandler i_NextHandler)
        {
            m_NextHandler = i_NextHandler;
        }
    }
}
