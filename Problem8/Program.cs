using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//8. Write a C# Sharp program that takes a number as input and print its multiplication table.
//Test Data:
//Enter the number: 5
//Expected Output:
//5 * 0 = 0
//5 * 1 = 5
//5 * 2 = 10
//5 * 3 = 15
//5 * 10 = 50



namespace Problem8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            int result;

            Console.Write("Please input first number :  ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");

            result = a * 1;
            Console.WriteLine("Multiplication : {0}x1= {2}", a, 1, result);
            result = a * 2;
            Console.WriteLine("Multiplication : {0}x2= {2}", a, 2, result);
            result = a * 3;
            Console.WriteLine("Multiplication : {0}x3= {2}", a, 3, result);
            result = a * 4;
            Console.WriteLine("Multiplication : {0}x4= {2}", a, 4, result);
            result = a * 5;
            Console.WriteLine("Multiplication : {0}x5= {2}", a, 5, result);
            result = a * 6;
            Console.WriteLine("Multiplication : {0}x6= {2}", a, 6, result);
            result = a * 7;
            Console.WriteLine("Multiplication : {0}x7= {2}", a, 7, result);
            result = a * 8;
            Console.WriteLine("Multiplication : {0}x8= {2}", a, 8, result);

            Console.ReadLine();
        }
    }
}
