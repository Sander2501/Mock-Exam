namespace Mock_Exam_8._4
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
            
            Console.Write("Enter course name: ");
            string courseName = Console.ReadLine();

            Console.Write("Enter number of students: ");
            int studentNumber = int.Parse(Console.ReadLine());

            string[] names = new string[studentNumber];
            int[] grades = new int[studentNumber];

            ReadNames(names);
            ReadGrades(grades);
            int highestGrade = GetHighestGradeIndex(grades);
            Console.WriteLine("");
            Console.WriteLine($"Student {names[highestGrade]} has the highest grade: {grades[highestGrade]}");


        }
        void ReadNames(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Enter the name of student {i + 1}: ");
                names[i] = Console.ReadLine();
            }
        }
        void ReadGrades(int[] grades)
        {
            for (int i = 0; i < grades.Length; i++)

            {
                Console.Write($"Enter grade of {i+1}: ");
                grades[i] = int.Parse(Console.ReadLine());
            }
        }
        int GetHighestGradeIndex(int[] grades)
        {
            int highestGrade = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] > grades[highestGrade])
                {
                    highestGrade = i;
                }
            }
            return highestGrade;

           
        }
    }
}
