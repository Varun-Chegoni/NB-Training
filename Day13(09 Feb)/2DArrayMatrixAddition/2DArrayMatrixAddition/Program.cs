using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArrayMatrixAddition
{
    internal class Program
    {
        /****************************************************************************
        * Author : Varun Sai Kumar Chegoni.
        * Purpose : Declare TWO 2-D arrays of size (2,2) and read values from user and print the sum of the two matrices.
       *****************************************************************************/
        static void Main(string[] args)
        {
            int i, j;
            int[,] mat1 = new int[2, 2];
            int[,] mat2 = new int[2, 2];
            int[,] matsum = new int[2, 2];            
            Console.Write("Enter elements in the first matrix:\n");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    mat1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("Enter elements in the second matrix:\n");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    mat2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("\nFirst matrix is:\n");
            for (i = 0; i < 2; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 2; j++)
                    Console.Write("{0} ", mat1[i, j]);
            }
            Console.Write("\nSecond matrix is:\n");
            for (i = 0; i < 2; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 2; j++)
                    Console.Write("{0} ", mat2[i, j]);
            }
            for (i = 0; i < 2; i++)
                for (j = 0; j < 2; j++)
                    matsum[i, j] = mat1[i, j] + mat2[i, j];
            Console.Write("\nAdding two matrices: \n");
            for (i = 0; i < 2; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 2; j++)
                    Console.Write("{0} ", matsum[i, j]);
            }
            Console.Write("\n\n");
            Console.ReadLine();
        }
    }
}
