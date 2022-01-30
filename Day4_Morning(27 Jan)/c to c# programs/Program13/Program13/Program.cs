using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program13
{
    internal class Program
    {
        public static bool Arm(int n)
        {
            int temp, sum = 0, rem;
            temp = n;
            while (n>0)
            {
                rem = n % 10;
                sum = sum + (rem * rem * rem);
                n = n / 10;
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
            Console.WriteLine("Write C# Program to Print Armstrong Number using Function by Varun");
            Console.WriteLine();

            int n;
            Console.WriteLine("enter number:");
            n = Convert.ToInt32(Console.ReadLine());
            if (Arm(n) == true)
                Console.WriteLine("{o} is Armstrong number", n);
            else
                Console.WriteLine("{0} is not Armstrong number", n);
            Console.ReadLine();
        }
    }
}
