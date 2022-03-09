using System;
namespace maxvalue
{    public class Program
    {
       int max=0;
       int []arr={23,34,1,10};//Declared array       
       void MaxValue()//function created
       {
           for (int i = 0; i < 4; i++)
           {
               if (arr[i]>max)//giving condition
               {
                   max=arr[i];                   
               }
           }
           Console.WriteLine("Max element in array is :"+max);
       }       
        static void Main(string[] args)
        {
            Program obj = new Program();//progran constructor created through new keyword
            obj.MaxValue();//function calling 
        }
    }
}

