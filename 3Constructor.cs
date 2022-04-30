using System;
namespace Constructor
{
    class Program
    {
        //This is constructor
        public Program()
        {
            Console.WriteLine("This is Constructor");
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
        }
    }
}
