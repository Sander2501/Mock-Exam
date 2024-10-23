using System.Threading.Channels;

namespace Mock_Exam_8
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
            Console.Write("Enter a day of the week (e.g., Monday):");
            string input = (Console.ReadLine());

            Day days = new Day();

            if (Enum.TryParse(input, out days))
            {
                switch (days)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        Console.WriteLine("Weekend is loading");
                        break;
                    case "Saturday":
                    case "Sunday":
                        Console.WriteLine("It's weekend!! Party time!");
                        break;
                    default:
                        Console.WriteLine("Enter a valid day of the week.");
                        break;
                }
            }
        }
    }
}
