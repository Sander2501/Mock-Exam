namespace Mock__Exam
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
            Console.Write("Enter the running distance(in kilometers): ");
            double distance = double.Parse(Console.ReadLine());

            Console.Write("Enter the time taken(in minutes): ");
            int time = int.Parse(Console.ReadLine());

            Console.Write("do you want to calculate the pace (min/km) or the speed (km/hr)?: ");
            string choice = Console.ReadLine();

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


        }
        double GetPace(double distance, int time)
        {
            return (time / distance);
        }
        double GetSpeed(double distance, int time)
        {
            return (distance / time) * 60;
        }
    }
}