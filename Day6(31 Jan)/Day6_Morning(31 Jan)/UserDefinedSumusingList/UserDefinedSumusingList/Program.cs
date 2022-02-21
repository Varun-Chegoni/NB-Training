using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedSumusingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to Print Sum of User defined values using for, foreach, lamda from List by Varun");
            Console.WriteLine("********************************************************************");

            //Variable Declaration
            int sum = 0,sum1 = 0, sum2 = 0,temp = 0;
            List<int> n = new List<int>();

            for(int i =0; i<5;i++)
            {
                Console.WriteLine("Enter Any Number");
                temp = Convert.ToInt32(Console.ReadLine());
                n.Add(temp);
            }

            //printing sum using for loop
            for (int i = 0; i < n.Count; i++) // logic
            {
                sum = sum + n[i]; // output
            }

            //printing sum using foreach loop
            foreach (var d in n) // logic
            {
                sum1 = sum1 + d; // output
            }

            //printing sum using lamda expression
            n.ForEach(d => sum2 = sum2 + d);
            
            // Print Output
            Console.WriteLine("sum by for loop : "+sum);
            Console.WriteLine("sum by foreach loop : "+sum1);
            Console.WriteLine("sum by lamda expression: "+sum2);
            Console.ReadLine();

        }
    }
}
