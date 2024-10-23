using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mock_Exam_5
{
    internal class Machine
    {
        public string _name { get; private set; } // read only 
        private int _numberOfWorkingHours; // backing field
        public int NumberOfWorkingHours
        {
            get 
            { 
                return _numberOfWorkingHours;                   
            }
            set
            {
                if (value >= 0)
                {
                    NumberOfWorkingHours = value;
                }
            }
        }
        public Machine(string name, int numberOfWorkingHours)  // [Program]Machine machine = new machine 
        {
            _name = name;
            _numberOfWorkingHours = numberOfWorkingHours;
        }
        public bool NeedsMaintenance
        {
            get
            {
                if (_numberOfWorkingHours >= 10000)
                {
                    return true;
                }
                return false;
            }
            
        }
        public  void DisplayInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Machine name: {_name}");
            Console.WriteLine($"Number of working hours: {_numberOfWorkingHours}");

            string maintenanceStatus = NeedsMaintenance ? "Yes" : "No";
            Console.WriteLine($"Needs maintenance: {maintenanceStatus}");
        }
    }
}
