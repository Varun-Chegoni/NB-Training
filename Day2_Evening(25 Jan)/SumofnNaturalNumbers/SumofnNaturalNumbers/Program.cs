using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofnNaturalNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print Sum of n Natural Number By Varun");
            Console.WriteLine("********************************************************************");

            // Varialbe Declaration
            int n, sum = 0, i;

            // User Input
            Console.WriteLine("Enter any Natural Number : ");
            n = Convert.ToInt32(Console.ReadLine());

            // Logic
            for (i = 0; i <= n; i++)
                sum = sum + i;

            // Print Output
            Console.WriteLine("Sum = " +sum);
            Console.ReadLine();
        }
    }
}
