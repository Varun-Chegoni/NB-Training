using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisionExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /****************************************************************************
        * Author : Varun Sai Kumar Chegoni.
        * Purpose : simple division program and handle three exceptions discussed in the class., also add super exception at the last.
       *****************************************************************************/

            try
            {
                int a, b, ans; // Variable Declaration 
                Console.WriteLine("Enter First Number: ");
                a=Convert.ToInt32(Console.ReadLine()); // Read Data
                Console.WriteLine("Enter First Number: ");
                b=Convert.ToInt32(Console.ReadLine()); // Read Data
                ans = a/b; // Logic
                Console.WriteLine("Answer = "+ans); // Output
                Console.ReadLine();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Please Enter Number within 0 to 999999999"); // Exception Output
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Please Enter Numbers only"); // Exception Output
                Console.ReadLine();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Number Cannot be divided by Zero"); // Exception Output
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Some Error Occured. Please Contact Us"); // Super Exception Output
                Console.ReadLine();
            }
        }
    }
}
