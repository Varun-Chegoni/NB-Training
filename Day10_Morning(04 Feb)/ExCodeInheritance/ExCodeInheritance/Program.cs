using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExCodeInheritance
{   
    class MathsBasics
        {
        public int a = 6;
        public int b = 2;
        public int AddNumbers()
        {
            return a + b;
        }
        public int DiffNumbers()
        {
            return a - b;
        }
        
    }
    class MathsComplex : MathsBasics
    {
        public int ProdNumbers()
        {
            return a * b;
        }
        public int DivNumbers()
        {
            return a / b;
        }
    }
    class MathsOperation : MathsComplex
    {
        public int Mod()
        {
            return a % b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Answer from single inherited class: ");
            MathsComplex ans = new MathsComplex();
            Console.WriteLine(ans.DiffNumbers());

            Console.WriteLine("Answer from MultiLevel Inherited class: ");
            MathsOperation ans1 = new MathsOperation();
            Console.WriteLine(ans.ProdNumbers());

            Console.ReadLine();
        }
    }
}
