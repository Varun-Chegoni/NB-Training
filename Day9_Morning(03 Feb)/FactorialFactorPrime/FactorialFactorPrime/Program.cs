using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialFactorPrime
{
    /****************************************************************************
        * Author : Varun Sai Kumar Chegoni.
        * Purpose : Write a C# program to read input from user and print Factorial,Factors,IsprimeorNot
       *****************************************************************************/
    class Factorial
    {
        private int input;
        public void ReadInput()
        {
            Console.WriteLine("Enter any Number : ");
            input = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintFactorial()
        {
            int fact = 1;
            for(int i =1 ; i <= input; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }

        public void PrintFactors()
        {
            for(int i =1 ; i <= input;i++)
            {
                if(input % i == 0)
                    Console.WriteLine(i);
            }
        }
        public bool IsPrimeorNot()
        {
            int count = 0;
            for (int i =1 ; i <= input;i++)
            {
                if (input % i == 0)
                    count++;
            }
            if (count == 2)
                return true;
            else 
                return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Factorial obj = new Factorial();
            obj.ReadInput();
            Console.WriteLine("Factorial of the Entered Number");
            obj.PrintFactorial();
            Console.WriteLine("Factors of the Entered Number");
            obj.PrintFactors();
            if (obj.IsPrimeorNot())
                Console.WriteLine("Entered Number is Prime Number");
            else
                Console.WriteLine("Entered Number is not a Prime Number");

            Console.ReadLine();
        }
    }
}
