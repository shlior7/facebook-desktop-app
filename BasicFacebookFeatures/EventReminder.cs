using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class EventReminder
    {
        private Event m_Event;
        private DateTime m_TimeToAlert;

        public EventReminder(Event i_Event, DateTime i_TimeToAlert)
        {
            m_Event = i_Event;
            m_TimeToAlert = i_TimeToAlert;
        }

        public DateTime TimeToAlert { get => m_TimeToAlert; set => m_TimeToAlert = value; }
        public Event Event { get => m_Event; set => m_Event = value; }

        public bool Equals(EventReminder other)
        {
            return m_Event.Id == other.Event.Id;
        }
        public override string ToString()
        {
            return $"The Event {Event.Name} will be at the location {Event.Location} on the {Event.TimeString}";
        }
    }
}
