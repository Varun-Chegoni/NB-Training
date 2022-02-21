using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassonCusProSelDept
{
    internal class Product
    {
        /****************************************************************************
         * Author : Varun Sai Kumar Chegoni
         * Purpose : Class Creation of Customer, Product, Seller, Department.
        *****************************************************************************/
        private int proid;
        private string proname;
        private int proprice;
        public void ReadProduct()
        {
            Console.WriteLine("Enter Product ID :");
            proid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Product Name :");
            proname = Console.ReadLine();

            Console.WriteLine("Enter Product Price :");
            proprice = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintProduct()
        {
            Console.WriteLine($"Product ID = {proid}, Product Name = {proname}, Product Price = {proprice}");
        }
    }
}
