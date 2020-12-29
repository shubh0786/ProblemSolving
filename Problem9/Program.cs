using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//9. Write a C# Sharp program that takes four numbers as input to calculate and print the average. Go to the editor
//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the third number: 20
//Enter the four number: 30

//Expected Output:
//The average of 10 , 15 , 20 , 30 is: 18

namespace Problem9
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter you number :  ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Please enter your number : ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Please enter you number : ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Please enter your number : ");
            int d  = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");

            int Add = a + b + c + d;
            int Average = Add / 4;
            Console.Write("Following is the average for provide number : {0}+{1}+{2}+{3} = {4}", a,b,c,d,Add);
            Console.WriteLine("\n");
            Console.Write("Following is the average for provide number : {0}", Average);
            Console.ReadLine();

        }
    }
}
