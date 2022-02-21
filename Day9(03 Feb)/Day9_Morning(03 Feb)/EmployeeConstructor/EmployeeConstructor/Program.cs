using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpClassansMethod
{
    /****************************************************************************
        * Author : Varun Sai Kumar Chegoni.
        * Purpose : Create an employee class with variables id, name, salary, company with two constructors.s
       *****************************************************************************/
    class Employee
    {
        public int id;
        public string name;
        public int salary;
        public static string company = "NationsBenefits";
        public Employee (int eid, string ename, int esalary)
        {
            id = eid;
            name = ename;
            salary = esalary;
        }
        public Employee()
        {
            this.id = 456;
            this.name = "Akash";
            this.salary = 20000;
        }
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
            Employee emp1 = new Employee(1,"Varun",30000);            
            emp1.PrintData();
            Console.WriteLine("Employee 2");
            Employee emp2 = new Employee();            
            emp2.PrintData();

            Console.ReadLine();
        }
    }
}
