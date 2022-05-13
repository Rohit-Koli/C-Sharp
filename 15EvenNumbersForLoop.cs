// Program to show first 3 even numbers in for loop.
using System;
namespace CSharp_Shell
{
    public class Program 
    {
        public static void Main()
        {
			int i;
			int n;
			Console.WriteLine("Enter a number:-");
		    n=Convert.ToInt32(Console.ReadLine());
		    Console.WriteLine("first 3 even numbers of 
given number in for loop:-");
		     for(i=1;i<=6;i++)
		    {
		        {
		    	if(i%2==0)
		    	{
		    	Console.WriteLine(i);
		        }
		       }
		    }
		    Console.ReadLine();
        }
    }
}
