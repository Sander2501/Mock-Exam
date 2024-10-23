using System.Globalization;

namespace Class._7
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
            Console.Write("Enter book title: ");
            string title = Console.ReadLine();

            Console.Write("Enter book author: ");
            string author = Console.ReadLine();

            Book book = new Book(title, author);
            Console.WriteLine();
            Console.WriteLine("Book Details: ");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
        }
    }
}
