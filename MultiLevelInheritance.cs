using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    class stud
    {
        public string name;
        public string class1;
        public void studinfo()
        {
            name = "Rohit";
            class1 = "SYBCA";
            Console.WriteLine("Name is " + name);
            Console.WriteLine("Class is " + class1);
        }
    }
    class exam : stud
    {
        public string subject;
        public void showinfo()
        {
            subject = "C sharp/c#";
            Console.WriteLine("Subject is " + subject);
        }
    }
    class result : exam
    {
        public int marks;
        public void marksinfo()
        {
            marks = 80;
            Console.WriteLine("Marks is " + marks);
        }        
    }
     class Program
        {
            static void Main(string[] args)
            {
                
                result r1 = new result();
                r1.studinfo();
                r1.showinfo();
                r1.marksinfo();
                Console.ReadLine();
            }
        }
    }

