using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program9
{
    internal class Program
    {
        public static void Prime(int input)
        {
            int i;
            for (i = 2; i< input; i++)
            {
                if (input % i == 0)
                    break;
            }
            if (i == input)
                Console.WriteLine("The given Input {0} is prime", input);
            else
                Console.WriteLine("The given Input {0} is no a prime", input);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write C# Program to Print Given Number is Prime Number or Not using Function by Varun");
            Console.WriteLine();

            {
                Console.WriteLine("enter input");// User Input
                Prime(Convert.ToInt32(Console.ReadLine()));
                Console.ReadLine();
            }

        }
    }
}
