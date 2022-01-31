using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringusingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to print name using for, foreach, lamda from List by Varun");
            Console.WriteLine("********************************************************************");
            // Variable Declaration
            List<string> name = new List<string>();
            name.Add("Varun");
            name.Add("Akash");
            name.Add("Shravan");
            name.Add("Ram");
            //printing name using for loop
            for(int i = 0 ; i < name.Count; i++) // logic
            {
                Console.WriteLine(name[i]); // output
            }
            //printing name using foreach loop
            foreach(var d in name) // logic
            {
                Console.WriteLine(d); // output
            }
            //printing name using lamda expression
            name.ForEach(n => Console.WriteLine(n));

            Console.ReadLine();
        }
    }
}
