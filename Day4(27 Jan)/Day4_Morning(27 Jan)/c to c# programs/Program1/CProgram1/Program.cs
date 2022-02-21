using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CProgram1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("program to Print Multiplication of a Number by Varun");
            Console.WriteLine();

            // Variable Declaration
            int input, i;

            // User Input
            Console.WriteLine("enter number");
            input = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= 10; i++) // Logic
            {
                Console.WriteLine(input + "x" + i + "x" + input * i); // Output

            }
            Console.ReadLine();
        }
    }
}
