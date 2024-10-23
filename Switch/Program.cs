using Switch_en_enum;

namespace Switch
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
            Console.Write("Enter a day of the week: ");
            string input = Console.ReadLine();

            try
            {
                // Convert the input string to a Day enum value
                Day day = (Day)Enum.Parse(typeof(Day), input, true);

                // Use a switch statement to print a message based on the day
                switch (day)
                {
                    case Day.Monday:
                        Console.WriteLine("Monday is the start of the week.");
                        break;
                    case Day.Tuesday:
                        Console.WriteLine("Tuesday is the second day of the week.");
                        break;
                    case Day.Wednesday:
                        Console.WriteLine("Wednesday is the middle of the week.");
                        break;
                    case Day.Thursday:
                        Console.WriteLine("Thursday is almost Friday!");
                        break;
                    case Day.Friday:
                        Console.WriteLine("Friday is the last day of the workweek.");
                        break;
                    case Day.Saturday:
                        Console.WriteLine("Saturday is the weekend!");
                        break;
                    case Day.Sunday:
                        Console.WriteLine("Sunday is the day of rest.");
                        break;
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid day of the week. Please try again.");
            }
        }
    }
}
