namespace Mock_Exam_8._7
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
            Machine machine = ReadMachine();
            machine.DisplayInfo();
        }

        Machine ReadMachine()
        {  
            Console.Write("Enter machine name: ");
            string name = Console.ReadLine();

            Console.Write("Enter number of working hours: ");
            int numberOfWorkingHours = int.Parse(Console.ReadLine());
            return new Machine(name, numberOfWorkingHours);
        }
    }
}
