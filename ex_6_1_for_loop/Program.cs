using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_6_1_for_loop
{
    class Program
    {
        static void Main()
        {
            /* 6-1  Write a program that prints on the console the numbers from 1 to N. 
            The number N should be read from the standard input. (Chapter 6, Exercise 1)
            */

            // Ask for input
            Console.WriteLine("This program prints on the console the numbers from 1 to N");
            Console.WriteLine("N=");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Number : " + i);
            }
            Console.ReadKey();
        }
    }
}
