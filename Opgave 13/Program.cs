namespace Opgave_13
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
            Console.Write("Enter employee name: ");
            string name = Console.ReadLine();

            Console.Write("Enter salary: ");
            double salary = int.Parse(Console.ReadLine());

            Employee employee = new Employee(name, salary);
            Console.WriteLine();
            Console.WriteLine("Employee Details: ");
            Console.WriteLine($"Name: {employee.name}");
            Console.WriteLine($"Salary: {employee.salary}");
            Console.WriteLine($"Bonus: {employee.Bonus}");
        }
    }
}
