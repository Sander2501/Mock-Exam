namespace Mock_Exam_4
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

            Drink drink1 = new Drink("Coca Cola", 3.00, false);
            Drink drink2 = new Drink("Orange Juice", 3.00, false);
            Drink drink3 = new Drink("Beer", 3.50, true);
            Drink drink4 = new Drink("Wine", 4.50, true);

            Drink[] drinks = { drink1, drink2, drink3, drink4 };
            DisplayDrinks(drinks);
        }
        void DisplayDrinks(Drink[] drinks)
        {
            for (int i = 0; i < drinks.Length; i++)
            {
                Console.WriteLine($"{i + 1}.{drinks[i].GetDescription()}");
            }
        }

    }
}
