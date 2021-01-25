using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z. Go to the editor
//Test Data:
//Enter first number - 5
//Enter second number - 6
//Enter third number - 7

//Expected Output:
//Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72



namespace Problem10
{
    class Program
    {
        static void Main(string[] args)
        {

            int x, y, z;

            int sum1, sum2;
            Console.Write("Please enter your first digit :");
            x = int.Parse(Console.ReadLine());
            
            Console.Write("Please enter your Second digit :");
            y = int.Parse(Console.ReadLine());

           
            Console.Write("Please enter your third digit :");
            z = int.Parse(Console.ReadLine());


            Console.WriteLine("\n");

            Console.WriteLine("Following are your numbers {0},{1},{2}",x,y,z);
            

            Console.WriteLine("\n");
            sum1 = (x + y)*z;
            sum2 = x * y + y * z;

            Console.WriteLine("Following are the result for (x+y)*z = {0}",sum1);
            Console.WriteLine("Following are the result for x*y+y*z = {0}", sum2);

            Console.ReadLine();





        }
    }
}
