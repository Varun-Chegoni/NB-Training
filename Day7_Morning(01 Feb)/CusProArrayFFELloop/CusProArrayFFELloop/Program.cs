using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CusProArrayFFELloop
{
    /****************************************************************************
        * Author : Varun Sai Kumar Chegoni.
        * Purpose : print customer and product , product price >=5000 using for loop foreach loop lambda expression.
       *****************************************************************************/
    public class Customer
    {
        public int cusid;
        public string cusname;
        public int cusno;
    }
    public class Product
    {
        public int proid;
        public string proname;
        public int proprice;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("print customer and product , product price >=5000 using for loop foreach loop lambda expression by Varun");
            Console.WriteLine("********************************************************************");

            Customer[] cus = new Customer[]
            {
                new Customer(){cusid=123, cusname="Varun",cusno=123456},
                new Customer(){cusid=234, cusname="Ravi",cusno=654321},
                new Customer(){cusid=456, cusname="Kiran",cusno=123654},
            };
            Product[] pro = new Product[]
            {
                new Product(){proid=987, proname="xphone",proprice=10000},
                new Product(){proid=876, proname="xwatch",proprice=5000},
                new Product(){proid=765, proname="xshoes",proprice=4000},
            };
            Console.WriteLine("Printing Output Using For Loop");
            // using for loop
            for (int i = 0; i<cus.Length; i++)
            {              
                    Console.WriteLine($"Customer ID = {cus[i].cusid}, Customer Name = {cus[i].cusname}, Customer Contact = {cus[i].cusno}");
            }

            // Customer Print*****************************************************************************************************************
            Console.WriteLine("Printing Output Using Foreach Loop");
            // using foreach loop
            foreach (var c in cus)
            {             
                    Console.WriteLine($"Customer ID = {c.cusid}, Customer Name = {c.cusname}, Customer Contact = {c.cusno}");
            }
            Console.WriteLine("Printing Outout Using Lamda Expression");
            // using lamda expression
            cus.ToList().ForEach(c => Console.WriteLine($"Customer ID = {c.cusid}, Customer Name = {c.cusname}, Customer Contact = {c.cusno}"));
            Console.ReadLine();

            // Product Print***************************************************************************************************
            Console.WriteLine("Printing Output Using For Loop");
            // using for loop
            for (int i = 0; i<pro.Length; i++)
            {                
                    Console.WriteLine($"Product ID = {pro[i].proid}, Product Name = {pro[i].proname}, Product Price = {pro[i].proprice}");
            }
            Console.WriteLine("Printing Output Using Foreach Loop");
            // using foreach loop
            foreach (var p in pro)
            {                
                    Console.WriteLine($"Product ID = {p.proid}, Product Name = {p.proname}, Product Price = {p.proprice}");
            }
            Console.WriteLine("Printing Outout Using Lamda Expression");
            // using lamda expression
            pro.ToList().ForEach(p => Console.WriteLine($"Product ID = {p.proid}, Product Name = {p.proname}, Product Price = {p.proprice}"));
            
            // Product Print >=5000 ***************************************************************************************************
            Console.WriteLine("Printing Output Using For Loop");
            // using for loop
            for (int i = 0; i<pro.Length; i++)
            {
                if (pro[i].proprice >= 5000)
                    Console.WriteLine($"Product ID = {pro[i].proid}, Product Name = {pro[i].proname}, Product Price = {pro[i].proprice}");
            }
            Console.WriteLine("Printing Output Using Foreach Loop");
            // using foreach loop
            foreach (var p in pro)
            {
                if (p.proprice>=5000)
                    Console.WriteLine($"Product ID = {p.proid}, Product Name = {p.proname}, Product Price = {p.proprice}");
            }
            Console.WriteLine("Printing Outout Using Lamda Expression");
            // using lamda expression
            pro.ToList().Where(p => p.proprice>=5000).ToList().ForEach(p => Console.WriteLine($"Product ID = {p.proid}, Product Name = {p.proname}, Product Price = {p.proprice}"));
            
            Console.ReadLine();

        }
    }
}
