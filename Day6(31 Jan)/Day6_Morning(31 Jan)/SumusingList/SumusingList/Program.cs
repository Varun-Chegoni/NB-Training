using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumusingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to declare List(generic) and find sum by Varun");
            Console.WriteLine("********************************************************************");
            // Variable Declaration
            int sum = 0;
            List<int> data = new List<int>();
            data.Add(20);
            data.Add(40);
            data.Add(60);
            data.Add(80);
            for(int i =0; i < data.Count; i++)
            {
                sum= sum + data[i]; // Logic
            }
            Console.WriteLine(sum); // Output
            Console.ReadLine();
        }
    }
}
