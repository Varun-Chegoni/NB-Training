using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassonCusProSelDept
{
    internal class Program
    {
        /****************************************************************************
         * Author : Varun Sai Kumar Chegoni
         * Purpose : Class Creation of Customer, Product, Seller, Department.
        *****************************************************************************/
        static void Main(string[] args)
        {
            Console.WriteLine("Class Creation of Customer, Product, Seller, Department");
            Console.WriteLine("********************************************************************");

            Customer cus = new Customer();
            cus.ReadCustomer();
            cus.PrintCustomer();

            Product pro = new Product();
            pro.ReadProduct();
            pro.PrintProduct();

            Seller sel = new Seller();
            sel.ReadSeller();
            sel.PrintSeller();

            Department dept = new Department();
            dept.ReadDepartment();
            dept.PrintDepartment();

            Console.ReadLine();
        }
    }
}
