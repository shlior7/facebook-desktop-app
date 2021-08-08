using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

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

        public string EventName
        {
            get
            {
                return m_Event.Name;
            }
        }

        public string EventLocation
        {
            get
            {
                return m_Event.Location;
            }
        }

        public string TimeBeforeToRemind
        {
            get
            {
                return $"{((DateTime)m_Event.StartTime).Subtract(TimeToAlert).ToString()} Before";
            }
        }

        public string EventStartTime
        {
            get
            {
                return m_Event.StartTime.ToString() ?? "No start time";
            }
        }

        public bool Equals(EventReminder i_Other)
        {
            return m_Event.Id == i_Other.Event.Id;
        }

        public override string ToString()
        {
            return $"The Event {Event.Name} will be at the location {Event.Location} on the {Event.TimeString}";
        }
    }
}
