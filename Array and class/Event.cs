using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Array_and_class
{
    internal class Event
    {
        private string eventName;
        private string date;
        private string location;

        public Event(string eventName, string date, string location)
        {
            this.eventName = eventName;
            this.date = date;
            this.location = location;
        }
        public string EventName
        {
            get { return this.eventName; }
            set { this.eventName = value; }
        }
        public string Date
        {
            get { return this.date; }
            set { this.date = value; }
        }
        public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }
    }

}
