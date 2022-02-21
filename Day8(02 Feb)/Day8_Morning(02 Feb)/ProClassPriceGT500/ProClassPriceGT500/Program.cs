using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProClassPriceGT500
{
    /****************************************************************************
        * Author : Varun Sai Kumar Chegoni.
        * Purpose : Create a class Product and add variables id, name, price, brand print product name and brand whose price is more than 500 Using FFELLINQ.
       *****************************************************************************/
    public class Product
    {
        public int id;
        public string name;
        public int price;
        public string brand;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create a class Product and add variables id, name, price, brand print product name and brand whose price is more than 500 Using FFELLINQ by Varun");
            Console.WriteLine("********************************************************************");

            List<Product> pro = new List<Product>()
            {
                new Product(){id=987, name="xshoes",price=100, brand="xuna"},
                new Product(){id=876, name="xphone",price=900, brand="xpple"},
                new Product(){id=765, name="xwatch",price=600, brand="xolex"},
                new Product(){id=654, name="xlaptop",price=1100, brand="xp"}
            };
            // Product Print >=500
            Console.WriteLine("Printing Output Using For Loop");
            // using for loop
            for (int i = 0; i<pro.Count; i++)
            {
                if (pro[i].price >= 500)
                    Console.WriteLine($"Product Name = {pro[i].name}, Product brand = {pro[i].brand}");
            }
            Console.WriteLine("Printing Output Using Foreach Loop");
            // using foreach loop
            foreach (var p in pro)
            {
                if (p.price>500)
                    Console.WriteLine($"Product Name = {p.name}, Product brand = {p.brand}");
            }
            Console.WriteLine("Printing Outout Using Lamda Expression");
            // using lamda expression
            pro.ToList().Where(p => p.price>=500).ToList().ForEach(p => Console.WriteLine($"Product Name = {p.name}, Product brand = {p.brand}"));
            Console.WriteLine("Printing Output Using LINQ Query ");
            // using LINQ Query
            var result = from p in pro
                         where p.price>=500
                         select p;
            result.ToList().ForEach(p => Console.WriteLine($"Product Name = {p.name}, Product brand = {p.brand}"));
            Console.ReadLine();
        }
    }
}
