using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArrayIntiIndexes
{
    internal class Program
    {
        /****************************************************************************
        * Author : Varun Sai Kumar Chegoni.
        * Purpose : Declare a 2-D array of size (3,3) and print trace of the array
       *****************************************************************************/
        static void Main(string[] args)
        {
            // Declaration and Intialization in same line
            int[,] a = new int[,] { { 1, 2, 3 }, { 2, 4, 6 }, { 3, 6, 9 } };
            int sum = 0;
            // Nested for Loop
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    if (i==j)
                        sum = sum + a[i, j]; // Logic
                }                
            }
            Console.WriteLine("Trace of the Array= "+sum);
            Console.ReadLine();
        }
    }
}

