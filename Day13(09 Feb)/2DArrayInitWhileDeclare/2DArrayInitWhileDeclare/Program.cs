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
        * Purpose : 2-D array of size (3,2) and initialize in the same line while declaring and print the values using nested for loop
       *****************************************************************************/
        static void Main(string[] args)
        {
            // Declaration and Intialization in same line
            int[,] a = new int[,] { {3,2,1}, {1,2,3} };            
            // Nested for Loop
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(a[i, j]+" "); // Print Output
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

