using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check
{
    internal class Program
    {
        public static void Main()
        {
            try
            {
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine(numbers[10]);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error Occured");
            }
            finally
            {
                Console.WriteLine("The operation is done.");
                Console.ReadLine(); 
            }
        }
    }
}

