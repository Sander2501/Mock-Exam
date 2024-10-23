namespace Mock_Exam_8._2
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
            book.DisplayBookInfo();
            
        }

    }
}
