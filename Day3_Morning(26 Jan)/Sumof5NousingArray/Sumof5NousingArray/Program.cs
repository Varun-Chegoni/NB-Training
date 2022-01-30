using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumof5NousingArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print Sum and Average of 5 Numbers using Array By Varun");
            Console.WriteLine("********************************************************************");

            // Varialbe Declaration
            int sum = 0, avg = 0;
            int[] data = new int[5];

            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine("Enter any Number : "); // User Input
                data[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < data.Length; i++)
            {
                sum = sum + data[i]; // Logic
            }
            avg = sum/data.Length;

            // Print Output
            Console.WriteLine("Sum = "+sum);
            Console.WriteLine("Average = "+avg);
            Console.ReadLine();
        }
    }
}
