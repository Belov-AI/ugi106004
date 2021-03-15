using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EuclidGeometry;

namespace GeometryUnitTestProject
{
    [TestClass]
    public class TriangleUnitTests
    {
        [TestMethod]
        public void ConstructorTest()
        {
            AssertCommonTriangle();
        }

        public static void AssertCommonTriangle()
        {
            var a = new Point(1, 1);
            var b = new Point(4, 1);
            var c = new Point(4, 5);

            var t = new Triangle(a, b, c);

            Assert.AreSame(a, t.A);
            Assert.AreSame(b, t.B);
            Assert.AreSame(c, t.C);

            Assert.AreSame(a, t.AB.A);
            Assert.AreSame(b, t.AB.B);
            Assert.AreSame(a, t.AC.A);
            Assert.AreSame(c, t.AC.B);
            Assert.AreSame(b, t.BC.A);
            Assert.AreSame(c, t.BC.B);
        }
    }
}
