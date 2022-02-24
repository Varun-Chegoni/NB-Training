using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoImplementedProperty
{
    class Student
    {
        // Auto-implimented Properties  
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            // Setting properties  
            student.ID    = 124;
            student.Name  = "Varun";
            student.Email = "Varun@example.com";
            // Getting properties  
            Console.WriteLine(student.ID);
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Email);

            Console.ReadLine();
        }
    }
}
