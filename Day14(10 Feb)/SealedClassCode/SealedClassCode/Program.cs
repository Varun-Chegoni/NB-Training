using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassCode
{
    /****************************************************************************
        * Author : Varun Sai Kumar Chegoni.
        * Purpose : sealed class illustration program 
       *****************************************************************************/
    sealed class SealedClass
    {

        // Calling Function
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an object of Sealed Class
            SealedClass slc = new SealedClass();

            // Performing Addition operation
            int total = slc.Add(6, 4);
            Console.WriteLine("Total = " + total.ToString());
            Console.ReadLine();
        }
    }
}
