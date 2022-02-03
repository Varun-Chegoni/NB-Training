using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpClassansMethod
{
    /****************************************************************************
        * Author : Varun Sai Kumar Chegoni.
        * Purpose : Create an employee class with variables id, name, salary, company and read and print method
       *****************************************************************************/
    class Employee
    {
        public int id;
        public string name;
        public int salary;
        public static string company = "NationsBenefits";
        public void ReadData()
        {
            Console.WriteLine("Enter Employee ID : ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary : ");
            salary = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintData()
        { 
            Console.WriteLine($"ID : {id}, Name : {name}, Salary : {salary}, Company : {company}");
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee 1");
            Employee emp1 = new Employee();
            emp1.ReadData();
            emp1.PrintData();
            Console.WriteLine("Employee 2");
            Employee emp2 = new Employee();
            emp2.ReadData();
            emp2.PrintData();

            Console.ReadLine();
        }
    }
}
