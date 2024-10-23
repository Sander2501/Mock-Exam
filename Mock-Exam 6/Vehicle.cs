using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mock_Exam_6
{
    internal class Vehicle
    {
        public string model { get; }
        public double fuelEfficiency;

        public double FuelEfficiency
        {
            get
            {
                return fuelEfficiency;
            }
            set
            {
                if (value > 0)
                {
                    fuelEfficiency = value;
                }
            }
        }

        public Vehicle(string model, double fuelEfficiency)
        {
            this.model = model;
            FuelEfficiency = fuelEfficiency;
        }
        bool IsFuelEfficient
        {
            get
            {
                if (fuelEfficiency >= 15)
                {
                    return true;
                }
                 return false;
            }
        }
        public void DisplayInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Fuel Efficiency: {fuelEfficiency} ");

            string fuelEfficient = IsFuelEfficient ? "Yes" : "No";
            Console.WriteLine($"fuelEfficiency: {fuelEfficient}");
        }
    }
}
