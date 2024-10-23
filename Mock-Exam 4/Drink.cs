using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mock_Exam_4
{
    internal class Drink
    {
        public string name { get; set; }
        public double price { get; set; }
        public bool isAlcoholic { get; set; }

        public Drink(string name, double price, bool isAlcoholic)
        {
            this.name = name;
            this.price = price;
            this.isAlcoholic = isAlcoholic;
        }
        string GetDescription()
        {
            string alcoholic = isAlcoholic ? "(alcoholic)" : "(not-alcoholic)";
            return $"{name}- {price} {alcoholic}";
        }
    }
}
