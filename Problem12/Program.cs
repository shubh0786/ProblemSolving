﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it two times: Use Console. Write and then use {0}. Go to the editor
//Test Data:
//Enter a digit: 25
//Expected Output:
//25 25 25 25
//25252525
//25 25 25 25
//25252525


namespace Problem12
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 25;

            Console.Write(a);
            Console.Write(" ");
            Console.Write(a);
            Console.Write(" ");
            Console.Write(a);
            Console.Write(" ");
            Console.Write(a);
            Console.Write(" ");
            Console.ReadLine();


        }
    }
}
