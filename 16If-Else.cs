# Program to demonstrate if else statement in c#.net.
using System;
namespace CSharp_Shell
{
    public class Program 
    {
        public static void Main()
        {
			int age;
			Console.WriteLine("Entet age of candidate");
			age=Convert.ToInt32(Console.ReadLine());
			
			if(age>=18)
			{
			    Console.WriteLine("Eligible for vote");
			}
			else
			{
	         	Console.WriteLine("Not eligible for vote");
			}
        }
    }
}
