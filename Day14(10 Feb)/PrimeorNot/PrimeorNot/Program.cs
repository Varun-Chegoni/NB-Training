using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeorNot
{
    /****************************************************************************
        * Author : Varun Sai Kumar Chegoni.
        * Purpose : number is prime or not using logic discussed in the class use break;
       *****************************************************************************/
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n = 63;
            for (i=2; i<n; i++)
            {
                if (n % i == 0)
                    break;
            }
            if (i==n)
                Console.WriteLine("63 is a Prime Number");
            else
                Console.WriteLine("63 is not Prime Number");
            Console.ReadLine();

        }
    }
}
