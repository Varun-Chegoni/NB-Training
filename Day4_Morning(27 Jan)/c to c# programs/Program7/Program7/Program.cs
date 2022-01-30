using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write C# Program to Print Power of a Given Number by Varun");
            Console.WriteLine();

            // Variable Declaration
            int b, ex;
            int p = 1;

            // User input
            Console.WriteLine("Enter first number:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            ex = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= ex; i++)
                p = p * b; // Logic

            Console.WriteLine("power =" + p); // output
            Console.ReadLine();

        }
    }
}
