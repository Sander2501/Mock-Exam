using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mock_Exam_8._7
{
    internal class Machine
    {
        public string name{ get; }
        public int numberOfWorkingHours;
         
        public Machine(string machine, int numberOfWorkingHours)
        {
            this.name = name;
            this.numberOfWorkingHours = numberOfWorkingHours;
        }

        public int NumberOfWorkingHours
        {
            get
            {
                return numberOfWorkingHours;
            }
            set
            {
                if (numberOfWorkingHours > 0)
                {
                    Console.WriteLine("Enter a valid number of working hours. ");

                }
            }
        }
        public bool NeedsMaintenance
        {
            get {
                if (numberOfWorkingHours >= 10000)
                {
                    return true;
                }
                return false;
            }
        }
        public void DisplayInfo() 
        {
            Console.WriteLine();
            Console.WriteLine($"Machine name: {name} ");
            Console.WriteLine($"Number of working hours: {numberOfWorkingHours}");

            string needsMaintenance = NeedsMaintenance ? "Yes" : "No";
            Console.WriteLine($"Needs maintenance: {needsMaintenance} ");
        }
    }
}
