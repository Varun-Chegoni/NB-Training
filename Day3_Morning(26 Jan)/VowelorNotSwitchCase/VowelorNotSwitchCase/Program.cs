using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelorNotSwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print Entered Character is Vowel or Not using Switch Case By Varun");
            Console.WriteLine("********************************************************************");

            // User Input
            Console.WriteLine("Enter a Character: ");
            char input = Convert.ToChar(Console.ReadLine()); // Varialbe Declaration

            // Logic
            switch(input)
            {
                case 'a':
                    Console.WriteLine("The Input Character is Vowel");
                    break;
                case 'e':
                    Console.WriteLine("The Input Character is Vowel");
                    break;
                case 'i':
                    Console.WriteLine("The Input Character is Vowel");
                    break;
                case 'o':
                    Console.WriteLine("The Input Character is Vowel");
                    break;
                case 'u':
                    Console.WriteLine("The Input Character is Vowel");
                    break;
                default:
                    Console.WriteLine("The Input Character is Consonent");
                    break ;
            }
            Console.ReadLine();
        }
    }
}
