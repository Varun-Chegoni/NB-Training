using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintHello5X
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print Hello 5 Times By Varun");
            Console.WriteLine("********************************************************************");

            for (int i = 1; i<=5; i++) // Logic
                Console.WriteLine("Hello"); // Print Output

            Console.ReadLine();
        }
    }
}
