using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//7. Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user. Go to the editor
//Test Data:
//Input the first number: 25
//Input the second number: 4
//Expected Output:
//25 + 4 = 29
//25 - 4 = 21
//25 x 4 = 100
//25 / 4 = 6
//25 mod 4 = 1


namespace Problem7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please input first number :  ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Please input second number :  ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            int Add = a + b;
            int Sub = a - b;
            int mul = a * b;
            int div = a / b;

            Console.WriteLine("Answer for addition is : {0}+{1} = {2}", a,b,Add);
            Console.WriteLine("\n");
            Console.WriteLine("Answer for Substraction is : {0}-{1} = {2}", a, b, Sub);
            Console.WriteLine("\n");
            Console.WriteLine("Answer for Multiplication is : {0}*{1} = {2}", a, b, mul);
            Console.WriteLine("\n");
            Console.WriteLine("Answer for Divide is : {0}/{1} = {2}", a, b, div);
            Console.WriteLine("\n");
            Console.ReadLine();

        }
    }
}
