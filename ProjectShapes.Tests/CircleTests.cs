using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProjectShapes.Tests
{
    [TestClass]
    public class CircleTests
    {
        /// Check for ArgumentException (The radius of the circle is zero)
        /// Should throw away ArgumentException!
        [ExpectedException(typeof(System.ArgumentException), "")]
        [TestMethod]
        public void CircleRadiusIsZero()
        {
            Circle _ = new Circle(0.0);
        }


        /// Check for ArgumentException (The radius of the circle is less than zero)
        [ExpectedException(typeof(System.ArgumentException), "")]
        [TestMethod]
        public void CircleRadiusIsLessThanZero()
        {
            Circle _ = new Circle(-0.5);
        }


        /// Checking the calculation of the area of the circle with accuracy
        [TestMethod]
        public void CircleAreaDeltaCompute()
        {
            Circle crc = new Circle(5.0);
            Assert.AreEqual(78.53981633, crc.GetArea, 1E-6, "Result out of range!");
        }

    }

}
