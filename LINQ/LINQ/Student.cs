using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    class Student
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public double Cgpa { get; set; }

        public void Show()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Cgpa: " + Cgpa);

        }
    }
}
