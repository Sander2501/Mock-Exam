namespace Mock_Exam_8._5
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
            Console.WriteLine("Welcome to the Cycling Performance Calculator! ");
            Console.WriteLine("Would you like to calculate the distance or the speed");
            string choice = Console.ReadLine();

            Console.Write("Enter the cycling distance int kilometers: ");
            int distance = int.Parse(Console.ReadLine());

            Console.Write("Enter the cycling time in hours: ");
            int time = int.Parse(Console.ReadLine());

            
            int speed = GetAverageSpeed(distance, time);
            if (choice == "pace")
            {
                double pace = GetPace(distance, time);
                Console.WriteLine($"Your running pace is {pace:0.00} minutes/kilometer.");
            }
            else if (choice == "speed")
            {
                double speed = GetSpeed(distance, time);
                Console.WriteLine($"Your running pace is {speed:0.00} kilometers/hour.");
            }
            else
            {
                Console.WriteLine("Error invalid input");
            }

            int distance = GetDistance(distance, time);
        }
            double GetAverageSpeed(double distance, double time)
            {
                return distance / time;

            }
            double GetDistance(double distance, double time)
            {
                return time / distance;

            }
        } 
    }
}
