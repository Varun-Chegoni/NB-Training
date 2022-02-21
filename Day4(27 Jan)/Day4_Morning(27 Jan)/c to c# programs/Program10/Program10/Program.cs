using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program10
{
    internal class Program
    {
        public static bool Prime(int input)

        {
            int i;
            for (i=2; i<input; i++)
            {
                if (input % i == 0)
                    break;
            }
            if (i == input)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write C# Program to Print Prime Number in Range by Varun");
            Console.WriteLine();

            int i, a, b; // Variable Declaration
            Console.WriteLine("Enter Starting Number: "); // User Input
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Last Numbar : "); // User Input
            b = Convert.ToInt32(Console.ReadLine());
            for (i = a; i <= b; i++)
            {
                if (Prime(i)) // Logic
                    Console.WriteLine(i); // Output
            }
            Console.ReadLine();
        }
    }
}
