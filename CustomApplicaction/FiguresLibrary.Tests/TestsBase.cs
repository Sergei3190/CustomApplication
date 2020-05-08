using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FiguresLibrary;

namespace FiguresLibrary.Tests
{
    [TestClass]
    public class TestsBase
    {
        [TestMethod]
        public void CircleAreaTest()
        {
            // arrange
            float expected = 12.56f;

            // act
            Circle circle = new Circle(2);
            float actual = circle.Area();

            // accert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TriangleAreaTest()
        {
            // arrange
            float expected = 6f;

            // act
            Triangle triangle = new Triangle(3,4,5);
            float actual = triangle.Area();

            // accert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void RightTriangleTest()
        {
            // arrange
            Triangle triangle1 = new Triangle(5, 4, 5);
            bool expected = false;

            // act
            bool actual = triangle1.RightTriangle(triangle1);

            // accert
            Assert.AreEqual(expected, actual);
        }
    }
}
