using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsBasicOperations
{
    /****************************************************************************
        * Author : Varun Sai Kumar Chegoni.
        * Purpose : Write C# program to read two numbers from use and print Addition, Differece, Product, Division.
       *****************************************************************************/

    public class MathsOperations
    {
        private int a;
        private int b;
        public void ReadInput()
        {
            Console.WriteLine("Enter First Number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            b = Convert.ToInt32(Console.ReadLine());
        }
        public int AddNumbers()
        {
            return a + b;
        }
        public int DiffNumbers()
        {
            return a - b;
        }
        public int ProdNumbers()
        {
            return a * b;
        }
        public int DivNumbers()
        {
            return a / b;
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            MathsOperations mo = new MathsOperations();
            mo.ReadInput();
            Console.WriteLine("Addition : ");
            Console.WriteLine(mo.AddNumbers());
            Console.WriteLine("Difference : ");
            Console.WriteLine(mo.DiffNumbers());
            Console.WriteLine("Product : ");
            Console.WriteLine(mo.ProdNumbers());
            Console.WriteLine("Division : ");
            Console.WriteLine(mo.DivNumbers());

            Console.ReadLine();
        }
    }
}
