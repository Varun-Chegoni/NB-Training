using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOrevloading
{
    public class Overloading
    {       
        public int Add(int a, int b)
        {
            return a + b;

        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Overloading obj = new Overloading();
            Console.WriteLine(obj.Add(2,4,8));

            Console.ReadLine();
        }
    }
}
