using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//6. Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user. Go to the editor
//Test Data:
//Input the first number to multiply: 2
//Input the second number to multiply: 3
//Input the third number to multiply: 6
//Expected Output:
//2 x 3 x 6 = 36

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input first number :  " );
            int a = int.Parse(Console.ReadLine());
       
            Console.Write("Please input second number :  " );
            int b = int.Parse(Console.ReadLine());
            
            Console.Write("Please input third number :  ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Following are the numbers provided by the user : {0},{1},{2} ;" + " ", a, b, c);
            Console.ReadLine();
            Console.WriteLine("\n");

            int d = a * b * c;

            Console.WriteLine("this is Multiplication for 3 numbers provided by the user :  {3} " + " ", a, b, c, d);
            Console.ReadLine();


        }
    }
}
