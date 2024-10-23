using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Student_Grade_Management
{
    internal class Student
    {
        public string Name;
        public int[] Grades;
        public Student(string name, int[] grades)
        {
            Name = name;
            Grades = grades;
        }

        public double CalculateAverage()
        {
            int sum = 0;
            foreach (int grade in Grades)
            {   
                sum += grade;
            }
            return (double)sum / Grades.Length;
        }
        public void DisplayGrades()
        {
            Console.WriteLine();
            Console.WriteLine($"Grades for {Name}");
            for (int i = 0; i < Grades.Length; i++)
            {
                Console.WriteLine($"Grade {i + 1}: {Grades[i]}");
            }
            double average = CalculateAverage();
            Console.WriteLine($"Average Grade: {average}");
        }
        public string name
        {
            get {  return name; }
        }
    }
}
