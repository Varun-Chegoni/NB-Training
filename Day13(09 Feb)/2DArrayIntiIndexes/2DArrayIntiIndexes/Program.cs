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
        * Purpose : 2 dimentional array of size (2,2) and initialize using indexes and print the values using nested for loop
       *****************************************************************************/
        static void Main(string[] args)
        {
            // Declaration
            int[,] a = new int[2,2];
            // indexes Initialization 
            a[0,0] = 5;
            a[0,1] = 7;
            a[1,0] = 4;
            a[1,1] = 6;
            // Nested for Loop
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++) 
                {
                    Console.Write(a[i,j]+" "); // Print Output
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
