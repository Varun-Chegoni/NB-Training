using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adding2Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition of Two Numbers By Varun");
            Console.WriteLine("********************************************************************");
            
            // Varialbe Declaration
            int fn, sn, sum = 0;

            // User Input
            Console.WriteLine("Enter First Number");
            fn = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter Second Number");
            sn = Convert.ToInt32(Console.ReadLine());

            // Logic
            sum = fn + sn;

            // Print Output
            Console.WriteLine("Answer: {0}+{1}={2}",fn,sn,sum);
            Console.ReadLine();
        }
    }
}
