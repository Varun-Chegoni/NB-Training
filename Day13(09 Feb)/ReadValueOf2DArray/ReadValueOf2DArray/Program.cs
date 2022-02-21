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
        * Purpose : Declare a 2-D array of size (2,2) and read values from user and print the array values.
       *****************************************************************************/
        static void Main(string[] args)
        {
            // Declaration
            int[,] a = new int[2,2];
            // Read Value from User
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"Enter Value of ({i},{j}): ");
                    a[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            }
            // Print Output
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                Console.Write(a[i,j]+" ");
                Console.Write("\n");
            }
            Console.Write("\n");
            Console.ReadLine();
        }
    }
}
