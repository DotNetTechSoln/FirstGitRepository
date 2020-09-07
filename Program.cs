using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            rectangle rectangle = new rectangle(23.21,23.23);
            rectangle.getArea();
            circle circle = new circle(23.12);
            circle.getArea();
            Console.WriteLine("area of rectangle is" + rectangle.getArea());
            Console.WriteLine("area of circle is" + circle.getArea());
            Console.ReadLine();
           
        }
    }
}
