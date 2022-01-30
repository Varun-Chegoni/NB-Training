using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizByVarun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Varialbe Declaration
            int score = 0, ans; 
            string name;

            Console.WriteLine("Enter your Name"); 
            name =Console.ReadLine(); // User Input
            Console.WriteLine("*********************************************************");
            Console.WriteLine("Hello {0}, Welcome to the quiz by Varun", name);
            Console.WriteLine("*********************************************************");

            Console.WriteLine("Q1. Total number of oceans in the World is");
            Console.WriteLine("1. Three     2. Five      3. Seven     4. Twelve");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 3) // Logic
                score += 20;
            Console.WriteLine("*********************************************************");
            Console.WriteLine("Q2. Which is the smallest ocean in the World?");
            Console.WriteLine("1. Indian     2. Pacific      3. Atlantic     4. Artic");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 4) // Logic
                score += 20;
            Console.WriteLine("*********************************************************");
            Console.WriteLine("Q3. Which one is the biggest island in the World?");
            Console.WriteLine("1. Borneo     2. Finland      3. Sumatra     4. Greenland");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 4) // Logic
                score += 20;
            Console.WriteLine("*********************************************************");
            Console.WriteLine("Q4. Which one is the largest tropical rain forest in the world?");
            Console.WriteLine("1. Amazon     2. Bosawas      3. Southeast Asian     4. Daintree");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 1) // Logic
                score += 20;
            Console.WriteLine("*********************************************************");
            Console.WriteLine("Q5. Which country first introduce the bullet trains?");
            Console.WriteLine("1. France     2. South Korea      3. Japan     4. USA");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 3) // Logic
                score += 20;
            Console.WriteLine("*********************************************************");
            if (score >= 60) // Logic
                Console.WriteLine("Congratulation {0}, you got {1}% in the quiz", name, score); // Print Output
            else
                Console.WriteLine("Sorry {0}, you got only {1}%. Try Again", name, score); // Print Output
            Console.ReadLine();
        }
    }
}
