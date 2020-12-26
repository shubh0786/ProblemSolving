using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//5. Write a C# Sharp program to swap two numbers. Go to the editor
//Test Data:
//Input the First Number : 5
//Input the Second Number : 6
//Expected Output:
//After Swapping :
//First Number : 6
//Second Number : 5


namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;


            Console.WriteLine("Numbers before swapping :" + " " + a);
            Console.WriteLine("Numbers before swapping :" + " "+ b);
            Console.WriteLine("\n");

            int c = a;
             a = b;
             b = a;


            Console.WriteLine("Numbers after swapping :" + " " + a );
            Console.WriteLine("Numbers after swapping :" + " " + b);
            Console.Read();



        }
    }
}
