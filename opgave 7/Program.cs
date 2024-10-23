namespace opgave_7
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
                Console.Write("Enter width: ");
                double width = double.Parse(Console.ReadLine());
                if (width < 0)
                {
                    Console.WriteLine("Enter a positive width. ");
                    break;
                }
                Console.Write("Enter height: ");
                double height = double.Parse(Console.ReadLine());
                if (height < 0)
                {
                    Console.WriteLine("Enter a positive height. ");
                    break;
                }


                Rectangle rectangle = new Rectangle(width, height);
                double area = rectangle.Area();
                double perimeter = rectangle.Perimeter();

                Console.WriteLine();
                Console.WriteLine("Rectangle Details: ");
                Console.WriteLine($"Width:{width}");
                Console.WriteLine($"Height:{height}");
                Console.WriteLine($"Area:{area}");
                Console.WriteLine($"Perimeter:{perimeter}");
            }
        }
    }
}
