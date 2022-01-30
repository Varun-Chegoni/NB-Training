using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello5XusingWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print Hello 5 Times using While Loop By Varun");
            Console.WriteLine("********************************************************************");

            int i = 1; // Varialbe Declaration

            while (i<=5) // Logic
            {
                Console.WriteLine("Hello"); // Print Output
                i++;
            }

            Console.ReadLine();
        }
    }
}
