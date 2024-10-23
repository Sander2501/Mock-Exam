﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mock_Exam_8._3
{
    internal class Person
    {
        public string Name;
        public int Age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Age: {Age}");
        }
    }
}
