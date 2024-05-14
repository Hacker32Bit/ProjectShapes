using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectShapes
{
    class ProjectShapes
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(5.0);
            Console.WriteLine("Created new Shape!");
            Console.WriteLine(circle.ToString());
            Console.WriteLine(circle.GetArea);
            Console.WriteLine("----------------------\n");

            Triangle triangle = new Triangle(3, 5, 5);
            Console.WriteLine("Created new Shape!");
            Console.WriteLine(triangle.ToString());
            Console.WriteLine(triangle.IsRight());
            Console.WriteLine("----------------------\n");

            Console.ReadKey();
        }
    }
}
