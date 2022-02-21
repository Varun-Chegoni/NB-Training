using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print Multiplication Table of a Given Number By Varun");
            Console.WriteLine("********************************************************************");

            int n, i = 1; // Varialbe Declaration

            // User Input
            Console.WriteLine("Enter any Number ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= 10; i++) // Logic
            {
                Console.WriteLine("{0}x{1}={2}", n, i, n * i); // Print Output
            }

            Console.ReadLine();
        }
    }
}
