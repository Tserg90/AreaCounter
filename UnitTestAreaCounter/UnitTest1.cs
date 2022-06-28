using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AreaCounterLib;

namespace UnitTestAreaCounter
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Тест отрицательный радиусом круга
        /// </summary>
        [TestMethod]
        public void CircleWrongRadiusTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Circle(-5));
        }

        /// <summary>
        /// Тест неправильными сторонами треугольника
        /// </summary>
        [TestMethod]
        public void TriangleWrongSidesTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(-5, 2, 1));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(1, -5, 5));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(2, 1, -3));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(-4, -1, -8));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(1, 2, 15));
        }

        /// <summary>
        /// Тест вычисления площади круга
        /// </summary>
        [TestMethod]
        public void CircleAreaCountTest()
        {
            var circle = new Circle(8);
            var circleArea = circle.GetArea();
            Assert.AreEqual(201.06192982974676, circleArea);
        }

        /// <summary>
        /// Тест вычисления площади тиугольника
        /// </summary>
        [TestMethod]
        public void TriangleAreaCountTest()
        {
            var triangle = new Triangle(4, 5, 6);
            var triangleArea = triangle.GetArea();
            Assert.AreEqual(9.921567416492214, triangleArea);
        }

        /// <summary>
        /// Тест на прямоугольный треугольник
        /// </summary>
        [TestMethod]
        public void RightTriangleTest()
        {
            var triangle = new Triangle(3, 4, 5);
            var isRightTriangle = triangle.IsRightTriangle;
            Assert.AreEqual(true, isRightTriangle);
        }

        /// <summary>
        /// Тест на непрямоугольный треугольник
        /// </summary>
        [TestMethod]
        public void NotRightTriangleTest()
        {
            var triangle = new Triangle(5, 5, 2);
            var isRightTriangle = triangle.IsRightTriangle;
            Assert.AreEqual(false, isRightTriangle);
        }
    }
}
