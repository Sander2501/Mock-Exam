namespace Opgave_4._1
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
            Drink[] drinks = new Drink[4];
            drinks[0] = new Drink("Coca cola", 3.00 , false);
            drinks[1] = new Drink("Orange juice", 3.00 , false);
            drinks[2] = new Drink("Beer", 3.50 , true);
            drinks[3] = new Drink("Wine", 4.50 , true);
            
            DisplayDrinks(drinks);

            double totalAmount = 0;
            while (true)
            {
                Console.WriteLine();
                Console.Write("Select a drink to order: ");
                Console.ForegroundColor = ConsoleColor.Green;
                int drinkNumber = int.Parse(Console.ReadLine());
                Console.ResetColor();
                if (drinkNumber == 0)
                {
                    break;
                }
                Drink selectedDrink = drinks[drinkNumber - 1];
                Console.Write($"How many {selectedDrink.Name} do you want to order?: ");
                Console.ForegroundColor = ConsoleColor.Green;
                int count = int.Parse(Console.ReadLine());
                Console.ResetColor();

                totalAmount = totalAmount + selectedDrink.Price * count;
            }
            Console.WriteLine();
            Console.WriteLine($"Total price you have to pay: {totalAmount:0.00}");
        }
        void DisplayDrinks(Drink[] drinks)
        {
            for (int i = 0; i < drinks.Length; i++)
            {
                string drinkInfo = drinks[i].GetDescription();
                Console.WriteLine($"{i + 1}. {drinkInfo}");
            }
        }
    }
}
