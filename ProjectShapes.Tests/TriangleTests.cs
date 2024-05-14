using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectShapes.Tests
{
    [TestClass]
    public class TriangleTest
    {
        /// One or more sides of Triangle is zero
        /// Should throw away ArgumentException!
        [ExpectedException(typeof(System.ArgumentException), "")]
        [TestMethod]
        public void SideIsZero()
        {
            Triangle _ = new Triangle(6.0, 0.0, 4.0);
        }


        /// One or more sides of Triangle is less than zero
        /// Should throw away ArgumentException!
        [ExpectedException(typeof(System.ArgumentException), "")]
        [TestMethod]
        public void SideIsLessThanZero()
        {
            Triangle _ = new Triangle(6.0, 10.0, -4.0);
        }


        /// The triangle does not exist
        /// Should throw away ArgumentException!
        [ExpectedException(typeof(System.ArgumentException), "")]
        [TestMethod]
        public void TriangleNotExist()
        {
            Triangle _ = new Triangle(25, 10, 5);
        }


        /// Checking the calculation of the area of the Triangle with accuracy
        [TestMethod]
        public void TriangleAreaDeltaCompute()
        {
            Triangle trg = new Triangle(40, 35, 25);
            Assert.AreEqual(433.0127018922, trg.GetArea, 1E-6, "Result out of range!");
        }


        /// Checking for the squareness of the triangle
        /// This triangle is rectangular
        [TestMethod]
        public void TriangleIsRight()
        {
            Triangle trg = new Triangle(17, 144, 145);
            Assert.IsTrue(trg.IsRight());
        }


        /// Checking for the squareness of the triangle
        /// This triangle is not rectangular
        [TestMethod]
        public void TriangleIsNotRight()
        {
            Triangle trg = new Triangle(17, 144, 145.04);
            Assert.IsFalse(trg.IsRight());
        }
    }
}
