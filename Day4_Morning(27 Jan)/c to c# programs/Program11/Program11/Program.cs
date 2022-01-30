using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write C# Program to Print Fibonacci Series by Varun");
            Console.WriteLine();
            // Variable Declaration
            int input;
            int next = 0;
            int prev = 0;

            Console.WriteLine("enter input");
            input = Convert.ToInt32((Console.ReadLine())); // User Input

            for (int i = 0; i<= input; i++)
            {
                if (next == 0)
                {
                    next = 1;
                }
                else
                {
                    int temp = next;
                    next = next + prev;
                    prev = temp; // Logic
                }
                Console.WriteLine(next); // Output
            }
            Console.ReadLine();
        }
    }
}
