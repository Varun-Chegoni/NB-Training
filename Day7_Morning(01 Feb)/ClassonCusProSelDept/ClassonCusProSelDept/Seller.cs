using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassonCusProSelDept
{
    internal class Seller
    {
        /****************************************************************************
         * Author : Varun Sai Kumar Chegoni
         * Purpose : Class Creation of Customer, Product, Seller, Department.
        *****************************************************************************/
        private int selid;
        private string selname;
        private string selemail;
        public void ReadSeller()
        {
            Console.WriteLine("Enter Seller ID :");
            selid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Seller Name :");
            selname = Console.ReadLine();

            Console.WriteLine("Enter Seller Email :");
            selemail = Console.ReadLine();
        }
        public void PrintSeller()
        {
            Console.WriteLine($"Seller ID = {selid}, Seller Name = {selname}, Seller Email = {selemail}");
        }
    }
}
