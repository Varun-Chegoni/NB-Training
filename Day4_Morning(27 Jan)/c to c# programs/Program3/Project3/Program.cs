using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a C# Program to Print Sum N Natural Numbers by Varun");
            Console.WriteLine();

            int input, sum = 0, i; // Variable Declaration

            // User input
            Console.WriteLine("enter any number");
            input = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= input; i++)
            {
                sum = sum + i; // Logic
            }

            Console.WriteLine(sum); // Print Output
            Console.ReadLine();
        }
    }
}
