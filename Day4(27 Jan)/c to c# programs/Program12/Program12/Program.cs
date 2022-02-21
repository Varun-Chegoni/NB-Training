using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write C# Program to Print Armstrong Number by Varun");
            Console.WriteLine();

            int number, rem, sum = 0, temp; // Variable Declaration
            Console.WriteLine("Enter Number"); //User input
            number = Convert.ToInt32(Console.ReadLine());
            temp = number;
            while (number > 0)
            {
                rem = number % 10;
                sum = sum + (rem*rem*rem);
                number = number / 10; // Logic
            }
            if (temp == sum)
            {
                Console.WriteLine("{0} is Armstrong", temp); // Output
            }
            else
            {
                Console.WriteLine("{0} is not Armsrong", temp); // Output
            }
            Console.ReadLine();
        }
    }
}
