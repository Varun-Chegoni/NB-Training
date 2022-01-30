using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write C# Program to Swap Numbers Without Using Third Variable by Varun");
            Console.WriteLine();

            int a = 4, b = 8;// Variable Declaration

            Console.WriteLine("Before Swaping :");
            Console.WriteLine("a = {0}, b = {1}", a, b);
            a= a + b;
            b= a - b;
            a= a - b; // Logic

            Console.WriteLine("After Swaping :");
            Console.WriteLine("a = {0}, b = {1}", a, b); // Output
            Console.ReadLine();
        }
    }
}
