using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnClassInitValues
{
    /****************************************************************************
        * Author : Varun Sai Kumar Chegoni.
        * Purpose : Create your own class and variables and initialize with some values for print using for ,foreach, lamda, LINQ
       *****************************************************************************/

    public class NHTraining
    {
        public string name;
        public int id;
        public int contact;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<NHTraining> nh = new List<NHTraining>()
            {
                new NHTraining() { name ="Arun", id = 01, contact = 123456},
                new NHTraining() { name ="Varun", id = 02, contact = 234567},
                new NHTraining() { name ="Vinay", id = 01, contact = 345678}
            };
            Console.WriteLine("Printing Output Using For Loop");
            // using for loop
            for (int i = 0; i<nh.Count; i++)
            {
                Console.WriteLine($"Student Name = {nh[i].name}, Student ID = {nh[i].id},  Student Contact = {nh[i].contact}");
            }

            Console.WriteLine("Printing Output Using Foreach Loop");
            // using foreach loop
            foreach (var n in nh)
            {
                Console.WriteLine($"Student Name = {n.name}, Student ID = {n.id},  Student Contact = {n.contact}");
            }

            Console.WriteLine("Printing Output Using Lamda Expression");
            // using lamda expression
            nh.ToList().ForEach(n => Console.WriteLine($"Student Name = {n.name}, Student ID = {n.id},  Student Contact = {n.contact}"));

            Console.WriteLine("Printing Output Using LINQ Query");
            // using LINQ Query
            var result = from n in nh
                         where n.contact > 1
                         select n;
            result.ToList().ForEach(n => Console.WriteLine($"Student Name = {n.name}, Student ID = {n.id},  Student Contact = {n.contact}"));
            Console.ReadLine();
        }
    }
}
