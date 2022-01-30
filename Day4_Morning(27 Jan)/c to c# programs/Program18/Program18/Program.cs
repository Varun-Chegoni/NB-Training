using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write C# Program to Swap Numbers Using Third Variable by Varun");
            Console.WriteLine();

            int a = 6, b = 9,t;// Variable Declaration

            Console.WriteLine("Before Swaping :");
            Console.WriteLine("a = {0}, b = {1}", a, b);
            t= a;
            a= b;
            b= t; // Logic

            Console.WriteLine("After Swaping :");
            Console.WriteLine("a = {0}, b = {1}", a, b); // Output
            Console.ReadLine();
        }
    }
}
