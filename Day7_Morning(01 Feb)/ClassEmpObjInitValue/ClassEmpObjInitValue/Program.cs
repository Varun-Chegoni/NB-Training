using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEmpObjInitValue
{
    /****************************************************************************
        * Author : Varun Sai Kumar Chegoni.
        * Purpose : Create Employee class with 3 public var. Create Emp object and init with values while creating obj and print the value.
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
            Console.WriteLine("Create Employee class with 3 public var. Create Emp object and init with values while creating obj and print the value by Varun");
            Console.WriteLine("********************************************************************");

            Employee emp = new Employee() { id = 123, name = "Varun", salary = 30000 };
            Console.WriteLine($"Employee ID : {emp.id}, Employee Name : {emp.name}, Employee Salary : {emp.salary}");
            Console.ReadLine();
        }
    }
}
