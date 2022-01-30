using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumbersfrom1to10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print Numbers from 1 to 10 By Varun");
            Console.WriteLine("********************************************************************");

            for (int i = 1; i<=10; i++) // Logic
                Console.WriteLine(i); // Print Output
            Console.ReadLine();
        }
    }
}
