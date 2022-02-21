using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitandExplicit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Program for Implicit and Explicit by Varun ");
            Console.WriteLine();

            // Implicit 
            short a = 20;
            int b = a;
            Console.WriteLine(b);

            // Explicit
            int p = 20;
            short q = (short) p;
            Console.WriteLine(b);

            Console.ReadLine();
        }
    }
}
