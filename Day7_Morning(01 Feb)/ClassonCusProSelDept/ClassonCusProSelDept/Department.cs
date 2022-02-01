using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassonCusProSelDept
{
    internal class Department
    {
        /****************************************************************************
         * Author : Varun Sai Kumar Chegoni
         * Purpose : Class Creation of Customer, Product, Seller, Department.
        *****************************************************************************/
        private int deptno;
        private string deptname;
        private string deptcat;
        public void ReadDepartment()
        {
            
            Console.WriteLine("Enter Department Number :");
            deptno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Department Name :");
            deptname = Console.ReadLine();

            Console.WriteLine("Enter Department Category :");
            deptcat = Console.ReadLine();
        }
        public void PrintDepartment()
        {
            Console.WriteLine($"Department Number = {deptno}, Department Name = {deptname}, Department Category = {deptcat}");
        }
    }
}
