﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpArrayInit5Emp
{
    /****************************************************************************
        * Author : Varun Sai Kumar Chegoni.
        * Purpose : create employee list and print using for ,foreach, lamda, LINQ
       *****************************************************************************/
    public class Employee
    {
        public int id;
        public string name;
        public int salary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("create employee list and print using for ,foreach, lamda, LINQ by Varun");
            Console.WriteLine("********************************************************************");

            List<Employee> emp = new List<Employee>()
            {
                new Employee() { id=123, name="Varun", salary=30000 },
                new Employee() { id=234, name="Ram", salary=20000 },
                new Employee() { id=345, name="Kiran", salary=40000 },
                new Employee() { id=456, name="Ravi", salary=20000 },
                new Employee() { id=567, name="Akash", salary=60000 },
            };
            
            Console.WriteLine("Printing Output Using For Loop");
            // using for loop
            for (int i = 0; i<emp.Count; i++)
            {
                Console.WriteLine($"Employee ID = {emp[i].id}, Employee Name = {emp[i].name}, Employee Salary = {emp[i].salary}");
            }
            
            Console.WriteLine("Printing Output Using Foreach Loop");
            // using foreach loop
            foreach (var e in emp)
            {
                Console.WriteLine($"Employee ID = {e.id}, Employee Name = {e.name}, Employee Salary = {e.salary}");
            }
            
            Console.WriteLine("Printing Output Using Lamda Expression");
            // using lamda expression
            emp.ToList().ForEach(e => Console.WriteLine($"Employee ID = {e.id}, Employee Name = {e.name}, Employee Salary = {e.salary}"));
            
            Console.WriteLine("Printing Output Using LINQ Query");
            // using LINQ Query
            var result = from e in emp
                         where e.id >= 1
                         select e;            
            result.ToList().ForEach(a => Console.WriteLine(a));
            Console.ReadLine();
        }
    }
}

