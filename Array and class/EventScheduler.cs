using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_class
{
    internal class EventScheduler
    {
        private Event[] events;
        private int currentIndex;

        // Constructor
        public EventScheduler(int capacity)
        {
            events = new Event[capacity];
            currentIndex = 0;
        }

        // Method to add an event
        public void AddEvent(Event eventToAdd)
        {
            if (currentIndex < events.Length)
            {
                events[currentIndex] = eventToAdd;
                currentIndex++;
                Console.WriteLine("Event added to scheduler.");
            }
            else
            {
                Console.WriteLine("Scheduler is full. Cannot add more events.");
            }
        }

        // Method to display all scheduled events
        public void DisplayEvents()
        {
            Console.WriteLine("\nScheduled Events:");
            for (int i = 0; i < currentIndex; i++)
            {
                Console.WriteLine($"{events[i].EventName} on {events[i].Date} at {events[i].Location}");
            }
        }
    }
}
