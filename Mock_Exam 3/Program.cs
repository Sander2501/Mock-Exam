namespace Mock_Exam_3
{
    internal class Program
    {
        //const int NumberOfElements = 20;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        void Start()
        {
            int[]numbers = new int[20];
            FillNumbers(numbers);

            int average = GetAverage(numbers);

            Console.WriteLine($"Calculated average number: {average}");
            Console.WriteLine("Numbers in the array:");

            DisplayNumbers(numbers,average);

        }
        void FillNumbers(int[] numbers)
        {
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 100);
            }
        }
        int GetAverage(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }
            int average = sum / numbers.Length;
            return average;
        }
        void DisplayNumbers(int[] numbers, int average)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < average)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (numbers[i] > average)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.Write($"{numbers[i]} ");
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
