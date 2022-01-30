using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a C# Program to Print Factorial of a Given Number");
            Console.WriteLine();

            int input, product = 1, i; // Variable Declaration

            // User Input
            Console.WriteLine("Enter any number");
            input = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= input; i++)
            {
                product = product * i; // Logic

            }
             // Print Output
            Console.WriteLine(product);
            Console.ReadLine();

        }
    }
}