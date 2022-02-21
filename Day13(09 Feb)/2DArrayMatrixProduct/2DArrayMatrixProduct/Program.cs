using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArrayMatrixProduct
{
    /****************************************************************************
        * Author : Varun Sai Kumar Chegoni.
        * Purpose : Declare TWO 2-D arrays of size (2,2) and read values from user and print the product of the two matrices.
       *****************************************************************************/
    class MatrixMultiplication
    {
        int[,] a = new int[2, 2];
        int[,] b = new int[2, 2];
        int[,] c = new int[2, 2];
        public void ReadMatrix()
        {            
             Console.WriteLine("\n Enter the elements of Matrix 1:");
             for (int i = 0; i < 2; i++)
             {
                 for (int j = 0; j < 2; j++)
                 {
                     a[i, j] = Convert.ToInt16(Console.ReadLine());
                 }
             }
             Console.WriteLine("\n Enter the elements of Matrix 2:");
             for (int i = 0; i < 2; i++)
             {
                 for (int j = 0; j < 2; j++)
                 {
                     b[i, j] = Convert.ToInt16(Console.ReadLine());
                 }
             }
            
        }
        public void PrintMatrix()
        {
            Console.WriteLine("\n Matrix 1:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(" " + a[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n Matrix 2:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(" " + b[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n Resultant Matrix after multiplying:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(" " + c[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        public void MultiplyMatrix()
        {
            c = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    c[i, j] = 0;
                    for (int k = 0; k < 2; k++) 
                        c[i, j] = c[i, j] + a[i, k] * b[k, j];
                }
            }
        }
    }
    class Matrices
    {
        public static void Main()
        {
            MatrixMultiplication MM = new MatrixMultiplication();
            MM.ReadMatrix();
            MM.MultiplyMatrix();
            MM.PrintMatrix();
        }
    }
}
