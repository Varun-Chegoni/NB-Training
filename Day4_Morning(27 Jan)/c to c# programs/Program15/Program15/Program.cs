using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write C# Program to Print Armstrong Number in Range by Varun");
            Console.WriteLine();

            int rem, sum = 0, n; // Variable Declaration
            Console.WriteLine("enter number:"); // User Input
            n = Convert.ToInt32(Console.ReadLine());
            int temp = n;
            while (n > 0)
            {
                rem = n % 10;
                sum = sum + rem;
                n = n / 10; // Logic
            }
            Console.WriteLine("Sum of given {0} is {1}", temp, sum); // Print Output
            Console.ReadLine();
        }
    }
}
