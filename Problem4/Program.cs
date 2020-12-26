using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//4. Write a C# Sharp program to print the result of the specified operations. Go to the editor
//Test data:

//-1 + 4 * 6
//( 35+ 5 ) % 7
//14 + -4 * 6 / 11
//2 + 15 / 6 * 1 - 7 % 2
//Expected Output:
//23
//5
//12
//3

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = -1 + 4 * 6;
            int b = (35 + 5) % 7;
            int c = 14 + -4 * 6 / 11;
            int d = 2 + 15 / 6 * 1 - 7 % 2;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.ReadLine();

        }
    }
}
