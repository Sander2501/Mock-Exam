namespace Array_and_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        void Start()
        {
            EventScheduler scheduler = new EventScheduler(10);
            while (true)
            {
                Console.Write("Enter event name (or type 'exit' to quit): ");
                string eventName = Console.ReadLine();
                if (eventName.ToLower() == "exit") break;

                Console.Write("Enter event date (YYYY-MM-DD): ");
                string date = Console.ReadLine();

                Console.Write("Enter event location: ");
                string location = Console.ReadLine();

                Event newEvent = new Event(eventName, date, location);
                scheduler.AddEvent(newEvent);
                scheduler.DisplayEvents();
            }
        }
    }
}
