// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
namespace Mehod
{
    class Program
    {
        static void MethodCalling()
        {
            Console.WriteLine("Method called");
        }
        static void function(int a,int b)
        {
            int sum=a+b;
            Console.WriteLine("sum is"+sum);
        }
        static void Main(string[] args)
        {
            int a,b;
            Console.WriteLine("Enter a:");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b:");
            b=Convert.ToInt32(Console.ReadLine());
            function(a,b);//call by refrence
            MethodCalling();
        }
    }
}
