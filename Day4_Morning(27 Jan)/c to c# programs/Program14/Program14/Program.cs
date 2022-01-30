using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program14
{
    internal class Program
    {
        public static bool Arm(int number)
        {
            int temp, sum = 0, rem;
            temp = number;
            while (number > 0)
            {
                rem = number % 10;
                sum = sum + (rem * rem * rem);
                number = number / 10;
            }
            if (temp == sum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write C# Program to Print Armstrong Number in Range by Varun");
            Console.WriteLine();

            int a, b; // Variable Declaration
            Console.WriteLine("enter Initial Value:"); // User Input
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter Last Value:"); // User Input
            b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                if (Arm(i))
                    Console.WriteLine(i); // Output
            }
            Console.ReadLine();
        }
    }
}
