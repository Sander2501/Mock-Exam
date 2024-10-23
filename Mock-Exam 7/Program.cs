namespace Mock_Exam_7
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
            double totalAmount = 0;
            while (true)
            {
                Book[] books = new Book[4];
                books[0] = new Book("Pupu", "Papa", 5.00, 200);
                books[1] = new Book("Lolo", "Walter", 9.00, 300);
                books[2] = new Book("POPO", "Nub", 89.00, 25);
                books[3] = new Book("Kiki", "Bob", 600.00, 900);

                DisplayBooks(books);
                Console.WriteLine();
                Console.Write("If you don't want to buy a book enter 0.");
                Console.WriteLine();
                Console.Write("Which book do you want to buy?: ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 0)
                {
                    break;
                }

                Console.WriteLine($"How many examples of {books[choice-1].Title}?");
                int amount = int.Parse(Console.ReadLine());

                totalAmount += (books[choice-1].Price) * amount;
            }
            Console.WriteLine($"the total amount is {totalAmount}");
        }

        void DisplayBooks(Book[] books)
        {
            for (int i = 0; i < books.Length; i++)
            {
                string bookInfo = books[i].GetDescription();
                Console.WriteLine($"{i+1}. {bookInfo}");
            }
        }
    }
}
