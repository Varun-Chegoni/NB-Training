using MyTestClientApp.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathsOperationsSoapClient obj = new MathsOperationsSoapClient();
            Console.WriteLine(obj.Factorial(4));
            Console.WriteLine(obj.Add(5, 10));
            Console.WriteLine(obj.Mul(2, 5));
            Console.WriteLine(obj.Add(6, 3));
            Console.ReadLine();
        }
    }
}
