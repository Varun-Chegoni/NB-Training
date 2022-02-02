using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNoPrintFFeLLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /****************************************************************************
        * Author : Varun Sai Kumar Chegoni.
        * Purpose : print even number using for, foreach loop, lambda expression, LINQ Query.
       *****************************************************************************/

            List<int> num = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 }; // Declaration ans Initialization 
            //Print Using For Loop
            Console.WriteLine("Printing using for loop");
            for (int i = 0; i < num.Count; i++)
            {
                if (num[i]%2 == 0)
                    Console.WriteLine(num[i]);
            }
            // Print using Foreach Loop 
            Console.WriteLine("Printing using foreach loop");
            foreach (int n in num)
            {
                if (n%2 == 0)
                    Console.WriteLine(n);
            }
            // Print using lamda Expression
            Console.WriteLine("Printing using Lamda Exp");
            num.Where(x => x % 2 == 0).ToList().ForEach(x => Console.WriteLine(x));
            // Print using LINQ Query
            Console.WriteLine("Printing using LINQ Query");
            var result = from n in num
                         where n % 2 == 0
                         select n;
            result.ToList().ForEach(n => Console.Write(n));
            Console.ReadLine();
        }
    }
}
