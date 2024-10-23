namespace Mock_Exam_2
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
            while (true)
            {
                Console.Write("Enter a positive integer: ");
                int number = int.Parse(Console.ReadLine());

                if (number <= 0)
                {
                    break;
                }

                int count = CountPrimeFactors(number);
                if (count == 1)
                {
                    Console.Write($"The number {number} is a prime number.");
                    Console.WriteLine();
                }
                else 
                {
                    Console.Write($"The number {number} has {count} prime factors. ");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine("End of program");
        }
        int CountPrimeFactors(int number)
        {
            int counter = 0;
            int divisor = 2;
            while (number >1) 
            {
                if (number % divisor == 0)
                {
                    number = number / divisor; // 10/2 => 5
                    counter++;
                }
                else
                {
                    divisor++; // 2 => 3 => 4 ....
                }
            }
            return counter;
        }
    }
}
