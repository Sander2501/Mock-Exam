namespace oefening_1
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
            Console.Write("Enter width: ");
            int width = int.Parse(Console.ReadLine());

            Console.Write("Enter height: ");
            int height = int.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(width, height);
            double area = rectangle.CalculateArea();
            double perimeter = rectangle.CalculatePerimeter();

            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"perimeter: {perimeter}");


        }
    }
}
