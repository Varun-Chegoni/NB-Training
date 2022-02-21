using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassonCusProSelDept
{
    internal class Customer
    {
        /****************************************************************************
        * Author : Varun Sai Kumar Chegoni
        * Purpose : Class Creation of Customer, Product, Seller, Department.
       *****************************************************************************/
        private int cusid;
        private string cusname;
        private string cusemail;
        public void ReadCustomer()
        {
           
            Console.WriteLine("Enter Customer ID :");
            cusid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Customer Name :");
            cusname = Console.ReadLine();

            Console.WriteLine("Enter Customer Email :");
            cusemail = Console.ReadLine();
        }
        public void PrintCustomer()
        {
            Console.WriteLine($"Customer ID = {cusid}, Customer Name = {cusname}, Customer Email = {cusemail}");
        }
    }
    
}
