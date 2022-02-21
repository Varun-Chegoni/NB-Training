using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeptClassEmpCountGT50
{
    /****************************************************************************
        * Author : Varun Sai Kumar Chegoni.
        * Purpose : Create a Department class and add variables id,name,empcount write code to print id,name of departments whose empcount is greater than 50
       *****************************************************************************/
    public class Department
    {
        public int id;
        public string name;
        public int count;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create a Department class and add variables id,name,empcount write code to print id,name of departments whose empcount is greater than 50 by Varun");
            Console.WriteLine("********************************************************************");

            List<Department> dept = new List<Department>()
            {
                new Department() { id=123, name="Analyst", count=60 },
                new Department() { id=234, name="Developer", count=70 },
                new Department() { id=345, name="Support", count=40 },
                new Department() { id=456, name="Recruiter", count=20 }                
            };
            // Employee count > 50
            Console.WriteLine("Printing Output Using For Loop");
            // using for loop
            for (int i = 0; i<dept.Count; i++)
            {
                if (dept[i].count > 50)
                    Console.WriteLine($"Department Name = {dept[i].name}, Department Employee Count = {dept[i].count}");
            }
            Console.WriteLine("Printing Output Using Foreach Loop");
            // using foreach loop
            foreach (var d in dept)
            {
                if (d.count>50)
                    Console.WriteLine($"Department Name = {d.name}, Department Employee Count = {d.count}");
            }
            Console.WriteLine("Printing Outout Using Lamda Expression");
            // using lamda expression
            dept.ToList().Where(d => d.count>50).ToList().ForEach(d => Console.WriteLine($"Department Name = {d.name}, Department Employee Count = {d.count}"));
            Console.WriteLine("Printing Output Using LINQ Query ");
            // using LINQ Query
            var result = from d in dept
                         where d.count>50
                         select d;
            result.ToList().ForEach(d => Console.WriteLine($"Department Name = {d.name}, Department Employee Count = {d.count}"));
            Console.ReadLine();
        }
    }
}
