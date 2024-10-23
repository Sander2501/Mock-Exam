namespace Array_Student_Grade_Management
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

            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            Console.Write("Enter amount of grades to process: ");
            int amount = int.Parse(Console.ReadLine());

            int[] grades = new int[amount];
            for (int i = 0; i < amount; i++)
            {
                int grade;
                do
                {
                    Console.Write($"Enter grade {i + 1}: ");
                    grade = int.Parse(Console.ReadLine());

                    if (grade < 0 || grade > 100)
                    {
                        Console.WriteLine("Invalid input. Please enter a grade between 0 and 100.");
                    }
                } while (grade < 0 || grade > 100);

                grades[i] = grade;  // Store the grade in the array
            }
            Student student = new Student(name, grades);
            student.DisplayGrades();
            student.CalculateAverage();

        }
    }
}
