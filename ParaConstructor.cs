using System;
namespace ParaConstructor
{
    class Program
    {
        public Program(int age,string name)
        {
            Console.WriteLine("age is :"+age);
            Console.WriteLine("name is :"+name);
        }
        static void Main(string[] args)
        {           
            Program program = new Program(19,"Rohit");
        }
    }
}
