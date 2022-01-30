using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumusingForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initializing an Array and Find Sum using foreach Loop By Varun");
            Console.WriteLine("********************************************************************");

            int sum = 0;
            int[] data = new int[] {2,4,6,8,10};

            foreach (int d in data)
                sum = sum + d; // Logic
            Console.WriteLine("Sum = "+sum); // Print Output
            Console.ReadLine();
        }
    }
}
