using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write C# Program to Read a Number and Check if it is Palindrome or Not by Varun");
            Console.WriteLine();

            int input, m, rem, rev = 0; // Variable Declaration

            Console.WriteLine("Enter any Number : ");
            input = Convert.ToInt32(Console.ReadLine());
            // Logic
            m = input;
            while (m > 0)
            {
                rem = m % 10;
                m = m/10;
                rev = rev * 10 + rem;
            }
            if (input == rev)
                Console.WriteLine("{0} is a Palindrome", input);
            else
                Console.WriteLine("{0} is not a Palindrome", input);
            Console.ReadLine();
        }
    }
}
