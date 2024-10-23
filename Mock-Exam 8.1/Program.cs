namespace Mock_Exam_8._1
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
            int[] numbers = new int[3];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter 3 integers: ");
                numbers[i]= int.Parse(Console.ReadLine());
            }
            int sum = CalculateSum(numbers);
            double average  = CalculateAverage(numbers);

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");

        }
        int CalculateSum(int[] number)
        {
            int sum = 0;
            foreach (var i in number)
            {
                sum += i;
            }
            return sum;
        }
        double CalculateAverage(int[] numbers)
        {
            double average = CalculateSum(numbers);    
            return (double)average / numbers.Length;
        }
    }
}
