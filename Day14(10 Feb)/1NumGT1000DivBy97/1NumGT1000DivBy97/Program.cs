using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1NumGT1000DivBy97
{
    /****************************************************************************
        * Author : Varun Sai Kumar Chegoni.
        * Purpose : first number after 1000 which is divisible by 97
       *****************************************************************************/
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 97;
            for (int i = 1000; i<=1097; i++)
            {
                if (i%n==0)
                {
                    Console.WriteLine(i);
                    break;
                }                
            }            
            Console.ReadLine();
        }
    }
}
