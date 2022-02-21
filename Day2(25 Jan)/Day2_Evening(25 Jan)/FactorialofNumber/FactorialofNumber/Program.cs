using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialofNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print Factorial of a Number By Varun");
            Console.WriteLine("********************************************************************");

            // Varialbe Declaration
            int n, p = 1, i;

            // User Input
            Console.WriteLine("Enter any Natural Number : ");
            n = Convert.ToInt32(Console.ReadLine());

            // Logic
            for (i = 1; i <= n; i++)
                p = p * i;

            // Print Output
            Console.WriteLine("Factorial = " + p);
            Console.ReadLine();
        }
    }
}
