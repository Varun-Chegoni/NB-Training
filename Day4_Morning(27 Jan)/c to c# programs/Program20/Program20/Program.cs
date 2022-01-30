using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write C# Program to Print Stars in Given Format by Varun");
            Console.WriteLine();

            int r, i, j; // Variable Declaration

            Console.WriteLine("Enter the Number of Rows to Print Star :"); // User Input
            r = Convert.ToInt32(Console.ReadLine());

            //Logic
            for (i = 0; i < r; i++)
            {
                    Console.WriteLine("*");
            }
            Console.ReadLine();
        }
    }
}
