using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpArrayInit5Emp
{
    /****************************************************************************
        * Author : Varun Sai Kumar Chegoni.
        * Purpose : create employees array object and initialize with 5 employees using fo ,foreach, lamda.
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
            Console.WriteLine("create employees array object and initialize with 5 employees using fo ,foreach, lamda. by Varun");
            Console.WriteLine("********************************************************************");

            Employee[] emp = new Employee[]
            {
                new Employee(){id=123, name="Varun",salary=30000},
                new Employee(){id=234, name="Ram",salary=20000},
                new Employee(){id=345, name="Kiran",salary=40000},
                new Employee(){id=456, name="Ravi",salary=20000},
                new Employee(){id=567, name="Akash",salary=60000},
            };
            Console.WriteLine("Printing Output Using For Loop");
            // using for loop
            for(int i=0;i<emp.Length;i++)
            {
                Console.WriteLine($"Employee ID = {emp[i].id}, Employee Name = {emp[i].name}, Employee Salary = {emp[i].salary}");
            }
            Console.WriteLine("Printing Output Using Foreach Loop");
            // using foreach loop
            foreach (var e in emp)
            {
                Console.WriteLine($"Employee ID = {e.id}, Employee Name = {e.name}, Employee Salary = {e.salary}");
            }
            Console.WriteLine("Printing Outout Using Lamda Expression");
            // using lamda expression
            emp.ToList().ForEach(e => Console.WriteLine($"Employee ID = {e.id}, Employee Name = {e.name}, Employee Salary = {e.salary}"));
            Console.ReadLine();
        }
    }
}
