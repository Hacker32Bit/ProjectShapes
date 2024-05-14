using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectShapes
{
    public class Triangle : Shape
    {
        readonly double[] Sides;

        /// Get Triangle Area
        public Triangle(double a, double b, double c) : base
            (Math.Sqrt((a + b + c) / 2 * (((a + b + c) / 2) - a) * (((a + b + c) / 2) - b) * (((a + b + c) / 2) - c)))
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Side length must be a positive number with double type!");
            else if (a + b < c || b + c < a || a + c < b)
                throw new ArgumentException("Wrong sides lenght for triangle");

            Sides = new double[3] { a, b, c };
        }


        /// Triangle is Right
        public bool IsRight()
        {
            Array.Sort(Sides);
            return Math.Abs(Math.Pow(Sides[0], 2) + Math.Pow(Sides[1], 2) - Math.Pow(Sides[2], 2)) == 0;
        }
    }
}
