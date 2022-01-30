using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplicationtable1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print Multiplication Table of a Given Number By Varun");
            Console.WriteLine("********************************************************************");

            int n, i; // Varialbe Declaration

            // User Input
            Console.WriteLine("Enter a Number");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i<= 10; i++) // Logic

                // Print Output
                Console.WriteLine(n+ "x" +i+ "=" +n*i); //string concatination

            Console.ReadLine();
        }
    }
}
