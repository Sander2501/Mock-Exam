using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_13
{
    internal class Employee
    {
        private string Name;
        private double Salary;

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public double salary
        {
            get { return Salary; }
            set { Salary = value; }
        }
        public double Bonus
        {
            get { return CalculateBonus(); }
        }
        private double CalculateBonus()
        {
            return salary * 0.10;
        }

    }
}
