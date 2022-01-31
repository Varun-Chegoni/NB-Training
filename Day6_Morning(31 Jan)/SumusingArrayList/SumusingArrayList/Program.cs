using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumusingArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to declare ArrayList and find sum by Varun");
            Console.WriteLine("********************************************************************");
            
            // Variable Declaration
            int sum = 0;
            ArrayList data = new ArrayList();
            data.Add(10);
            data.Add(20);
            data.Add(30);
            data.Add(40);
            data.Add(50);

            for (int i=0;i<data.Count;i++)
            {
                sum = sum + Convert.ToInt32( data[i]); // Logic           
            }
            Console.WriteLine(sum); // Output
            Console.ReadLine();
        }
    }
}
