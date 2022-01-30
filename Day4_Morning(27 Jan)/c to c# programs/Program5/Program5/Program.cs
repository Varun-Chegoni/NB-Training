using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    internal class Program
    {
        public static int Factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i < n; i++)
                fact *= i;
            return fact;
        }
        public static void print(int n)
        {
            Console.WriteLine("Facorial of {0} = {1}", n, Factorial(n));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write C# Program to Print Factorial using Recursion by Varun");
            Console.WriteLine();

            int n = 4, n1 = 5, n2 = 7;
            print(n);
            print(n1);
            print(n2);
            Console.ReadLine();
        }
    }
}
