namespace oefening_2
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
            Console.Write("Enter the running distance (in kilometer): ");
            double distance = double.Parse(Console.ReadLine());

            Console.Write("Enter the time taken (in minutes): ");
            int time = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Do you want to calculate pace (min/km) or speed (km/hr)?: ");
            string choice = Console.ReadLine();

            

            if (choice == "pace")
            {
                double pace = GetPace(distance, time);
                Console.WriteLine($"Your pace is: {pace:0.00}");
            }
            else if (choice == "speed")
            {
                double speed = GetSpeed(distance, time);
                Console.WriteLine($"Your pace is: {speed:0.00} ");

            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
        double GetPace(double distance, int time)
        {
            return (time / distance);
        }
        double GetSpeed(double distance, int time)
        {
            return distance/time *60;
        }
    }
}
