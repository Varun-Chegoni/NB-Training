using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadValuesusingForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print Entered 4 Number by User using foreach Loop By Varun");
            Console.WriteLine("********************************************************************");

            // Varialbe Declaration
            int sum = 0;
            int[] data = new int[4];

            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine("Enter any Number : "); // User Input
                data[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int d in data) // Logic
                Console.WriteLine(d); // Print Output
            Console.ReadLine();
        }
    }
}
