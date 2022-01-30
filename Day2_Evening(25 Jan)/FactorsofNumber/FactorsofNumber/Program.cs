using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorsofNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print Factors of a Given Number By Varun");
            Console.WriteLine("********************************************************************");

            int n, i; // Varialbe Declaration

            // User Input
            Console.WriteLine("Enter any Number ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++) // Logic
            {
                if (n % i == 0)
                    Console.WriteLine(i); // Print Output
            }

            Console.ReadLine();
        }
    }
}
