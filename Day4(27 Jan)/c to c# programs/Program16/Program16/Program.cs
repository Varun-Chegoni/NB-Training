using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write C# Program to Print Reverse of a Given by Varun");
            Console.WriteLine();

            int n, temp, rem, rev = 0; // Variable Declaration
            Console.WriteLine("Enter Number"); // User Input
            n = Convert.ToInt32(Console.ReadLine());
            temp = n;
            while (n>0)
            {
                rem = n % 10;
                rev = (rev * 10) + rem;
                n = n / 10; // Logic
            }
            Console.WriteLine("The reverse of {0} is {1}", temp, rev); // Print Output
            Console.ReadLine();
        }
    }
}
