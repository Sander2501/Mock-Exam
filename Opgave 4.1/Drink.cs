namespace Opgave_4._1
{
    internal class Drink
    {
        //....
        public string Name;
        public double Price;
        public bool IsAlcoholic;
        public Drink(string name, double price, bool isAlcoholic) 
        {
            Name = name;
            Price = price;
            IsAlcoholic = isAlcoholic;
        }
        public  string GetDescription()
        {
            if (IsAlcoholic)
            {
                return $"{Name} - {Price:0.00} (Alcoholic)";
            }
            else
            {
                return $"{Name} - {Price:0.00} (Non-Alcoholic)";

            }
        }
    }
}
