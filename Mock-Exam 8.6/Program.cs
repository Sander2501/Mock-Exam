namespace Mock_Exam_8._6
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
            int[] diceCounts = new int[6];
            int numberOfThrows = 6000;
            ThrowDice(diceCounts, numberOfThrows);
            DisplayResult(diceCounts);
           

        }
        void ThrowDice(int[] diceCounts, int numberOfThrows)
        {
            Random random = new Random();
            for (int i = 0; i < numberOfThrows; i++)
            {
                int diceValue = random.Next(1, 7);
                diceCounts[diceValue - 1]++;
            }
        }
        void DisplayResult(int[] diceCounts)
        {

            for (int i = 0; i < diceCounts.Length; i++)
            {
                int count = diceCounts[i];
                Console.WriteLine($"Number of throws of value {i + 1} = {count} ");
            }
        }
    }
}
