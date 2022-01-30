using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aPowerb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print Power of Base and Exponent Numbers By Varun");
            Console.WriteLine("********************************************************************");

            // Varialbe Declaration
            int b, e, p = 1;

            // User Input
            Console.WriteLine("Enter Base Number");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Exponent Number");
            e = Convert.ToInt32(Console.ReadLine());

            // Logic
            /* for (int i = 1; i <= e; i++) // by for loop
                p = p * b; */
            p = Convert.ToInt32(Math.Pow(b, e)); // .net framework

            // Print Output
            Console.WriteLine("Power = " + p);
            Console.ReadLine();
        }
    }
}
