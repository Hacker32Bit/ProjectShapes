using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectShapes
{
    public class Circle : Shape
    {
        /// Get Circle Area
        public Circle(double r) : base(Math.PI * r * r)
        {
            if (r <= 0.0)
                throw new ArgumentException("Radius must be a positive number with double type!");
        }
    }
}
