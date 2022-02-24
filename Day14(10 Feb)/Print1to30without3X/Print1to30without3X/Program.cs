using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print1to30without3X
{
    /****************************************************************************
        * Author : Varun Sai Kumar Chegoni.
        * Purpose : print numbers from 1 to 30 and skip the numbers divisible by 3 use continue;
       *****************************************************************************/
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            for (int i = 1; i<=30; i++)
            {
                if (i % 3 == 0)
                    continue;
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
