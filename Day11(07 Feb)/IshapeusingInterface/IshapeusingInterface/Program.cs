using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IshapeusingInterface
{
    /****************************************************************************
        * Author : Varun Sai Kumar Chegoni.
        * Purpose : Write example program for interfaces discussed in the class IShape include the classes Circle, Square, Triangle, Rectangle.
       *****************************************************************************/
    /// <summary>
    /// interface containg calculation of perimeter and area method.
    /// </summary>
    interface IShape
    {
        int CalculatePerimeter();
        int CalculateArea();     
    }
    /// <summary>
    /// class Circle inherits interface IShape reads data and calculate perimeter and area.
    /// </summary>
    class Circle : IShape
    {
        int radius; // Variable Declaration 
        public void ReadData()
        {
            Console.WriteLine("Enter Radius of Circle :");
            radius = Convert.ToInt32(Console.ReadLine()); // Read Data from User

        }        
        public int CalculatePerimeter()
        {
            return 2 * 22 * radius/7; // Logic
        }
        public int CalculateArea()
        {
            return 22 * radius *radius/7; // Logic
        }
    }
    /// <summary>
    /// class Square inherits interface IShape reads data and calculate perimeter and area.
    /// </summary>
    class Square : IShape
    {
        int side; // Variable Declaration 
        public void ReadData()
        {
            Console.WriteLine("Enter Side of Square :");
            side = Convert.ToInt32(Console.ReadLine()); // Read Data from User

        }
        public int CalculatePerimeter()
        {
            return 4 * side; // Logic
        }
        public int CalculateArea()
        {
            return side * side; // Logic
        }
    }
    /// <summary>
    /// class Triangle inherits interface IShape reads data and calculate perimeter and area.
    /// </summary>
    class Triangle : IShape
    {
        int a, b, c;
        int height;
        int ba; // Variable Declaration 
        public void ReadData()
        {
            Console.WriteLine("Enter Side A of Triangle:");
            a = Convert.ToInt32(Console.ReadLine()); // Read Data from User
            Console.WriteLine("Enter Side B of Triangle:");
            b = Convert.ToInt32(Console.ReadLine()); // Read Data from User
            Console.WriteLine("Enter Side C of Triangle:");
            c = Convert.ToInt32(Console.ReadLine()); // Read Data from User
        }
        public int CalculatePerimeter()
        {
            return a + b + c; // Logic
        }
        public void ReadDataA()
        {
            Console.WriteLine("Enter Height of Triangle:");
            a = Convert.ToInt32(Console.ReadLine()); // Read Data from User
            Console.WriteLine("Enter Base of Triangle:");
            b = Convert.ToInt32(Console.ReadLine()); // Read Data from User
        }
        public int CalculateArea()
        {
            return height * ba / 2; // Logic
        }
    }
    /// <summary>
    /// class Rectangle inherits interface IShape reads data and calculate perimeter and area.
    /// </summary>
    class Rectangle : IShape
    {
        int l, b; // Variable Declaration 
        public void ReadData()
        {
            Console.WriteLine("Enter Length of Rectangle:");
            l = Convert.ToInt32(Console.ReadLine()); // Read Data from User
            Console.WriteLine("Enter Breadth of Rectangle:");
            b = Convert.ToInt32(Console.ReadLine()); // Read Data from User
        }
        public int CalculatePerimeter()
        {
            return 2 * (l + b); // Logic
        }
        public int CalculateArea()
        {
            return l * b; // Logic
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.ReadData();
            Console.WriteLine("Circumference of Circle is " + c.CalculatePerimeter());
            Console.WriteLine("Area of Circle is " + c.CalculateArea()); // Print Output
            Square s = new Square();
            s.ReadData();
            Console.WriteLine("Perimeter of Square is " + s.CalculatePerimeter());
            Console.WriteLine("Area of Square is " + s.CalculateArea()); // Print Output
            Triangle t = new Triangle();
            t.ReadData();
            Console.WriteLine("Perimeter of Triangle is " + t.CalculatePerimeter());
            t.ReadDataA();
            Console.WriteLine("Area of Triangle is " + s.CalculateArea()); // Print Output
            Rectangle r = new Rectangle();
            r.ReadData();
            Console.WriteLine("Perimeter of Rectangle is " + r.CalculatePerimeter());
            Console.WriteLine("Area of Rectangle is " + r.CalculateArea()); // Print Output

            Console.ReadLine();
        }
    }
}
