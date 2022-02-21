using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a C# Program to Print Factors of a Given Number by Varun");
            Console.WriteLine();

            int input, i; // Variable Declaration
            Console.WriteLine("Enter any number"); // User Input
            input = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= input; i++)
            {
                if (input % i == 0) // Logic
                    Console.WriteLine(i); // Output
            }
            Console.ReadLine();

        }
    }
}
