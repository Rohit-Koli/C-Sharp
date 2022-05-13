//Program to demonstrate destructor in c#.net.
Using System;
namespace CSharp_Shell
{
  Public class Program 
    {
          Public Program()
             {
		Console.WriteLine(“Constructor called”);
                    }
                      ~Program()
                         {
                  	Console.WriteLine(“Destructor called”);
                  	}
                    Public static void Main(string [] args)
                       }
                                 Program p=new Program();
                       }
  }
}
