using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTableusingWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print Multiplication Table using While Loop By Varun");
            Console.WriteLine("********************************************************************");

            int n, i = 1; // Varialbe Declaration

            // User Input
            Console.WriteLine("Enter any Number");
            n = Convert.ToInt32(Console.ReadLine());

            while (i<=10) // Logic
            {
                Console.WriteLine(n+"x"+i+"="+n*i); // Print Output
                i++;
            }
            Console.ReadLine();
        }
    }
}
