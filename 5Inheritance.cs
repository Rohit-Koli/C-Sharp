using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inheritance
{
    class stud
    {
        string name;
        public void stud1()
        {
            name = "Rohit";
            Console.WriteLine("Student Name is " + name);
        }
        
    }
    class marks :stud
    {
        int m;
        public void marks1()
        {
            m = 77;
            Console.WriteLine("Marks are "+ m);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            marks m = new marks();
            m.stud1();
            m.marks1();
            Console.ReadLine();
        }
    }
}
