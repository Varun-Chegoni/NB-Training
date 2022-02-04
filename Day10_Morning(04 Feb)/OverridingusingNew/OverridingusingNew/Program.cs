using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingusingNew
{
    class EnglishMsg
    {
        public void PrintHi()
        {
            Console.WriteLine("Hi");
        }
        public void PrintHello()
        {
            Console.WriteLine("Hello");
        }
        public void PrintGM()
        {
            Console.WriteLine("Good Morning");
        }
    }
    class HindiMsg : EnglishMsg
    {       
        public new void PrintGM()
        {
            Console.WriteLine("Subodhay");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            HindiMsg msg = new HindiMsg();
            msg.PrintGM();

            Console.ReadLine();
        }
    }
}
