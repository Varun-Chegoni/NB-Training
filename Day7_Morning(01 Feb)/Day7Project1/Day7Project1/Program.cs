using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Project1
{
    class Employee
    {
        /****************************************************************************
         * Author : Varun Sai Kumar Chegoni
         * Purpose : Create Employee class with three variables and two methods
   ReadEmployee and PrintEmployee and create an object and call methods.
        *****************************************************************************/
        
        private int id;
        private string name;
        private int salary;

        public void ReadEmployee()
        {
            Console.WriteLine("Enter Employee ID :");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Name :");
            name = Console.ReadLine();

            Console.WriteLine("Enter Employee Salary :");
            salary = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintEmployee()
        {
            Console.WriteLine($"Employee = {id}, Employee Name = {name}, Employee Salary = {salary}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee class with three variables and two methods By Varun");
            Console.WriteLine("********************************************************************");

            Employee emp = new Employee();
            emp.ReadEmployee();
            emp.PrintEmployee();

            Console.ReadLine();
        }
    }
}
