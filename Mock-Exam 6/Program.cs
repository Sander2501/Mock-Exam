using System.Diagnostics.Metrics;
using System.Numerics;
using System.Reflection.PortableExecutable;

namespace Mock_Exam_6
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
            Vehicle vehicle = ReadVehicle();
            vehicle.DisplayInfo();

        }
        Vehicle ReadVehicle()
        {
            Console.Write("Enter the vehicle model: ");
            string model = (Console.ReadLine());

            Console.Write("Enter the fuel efficiency (km/l):");
            double fuelEfficiency = double.Parse(Console.ReadLine());

            return new Vehicle(model, fuelEfficiency);
        }

    }
}
