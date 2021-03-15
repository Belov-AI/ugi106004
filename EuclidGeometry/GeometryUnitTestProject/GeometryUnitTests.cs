using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EuclidGeometry;

namespace GeometryUnitTestProject
{
    [TestClass]
    public class GeometryUnitTests
    {
        [TestMethod]
        public void CreateSegmentTest()
        {
            var a = new Point(1, 2);
            var b = new Point(-1, 5);

            var s = Geometry.CreateSegment(a, b);

            Assert.AreSame(a, s.A);
            Assert.AreSame(b, s.B);
        }

        [TestMethod]
        public void IsPointInsideSegmentTest()
        {
            var s = new Segment(new Point(1, 1), new Point(5, 3));

            var m1 = new Point(3, 2);
            var m2 = new Point(-1, 0);
            var m3 = new Point(2, 3);

            Assert.IsTrue(Geometry.IsPointInsideSegment(m1, s));
            Assert.IsFalse(Geometry.IsPointInsideSegment(m2, s));
            Assert.IsFalse(Geometry.IsPointInsideSegment(m3, s));
        }

        [TestMethod]
        public void CreateTriangleTest()
        {
            TriangleUnitTests.AssertCommonTriangle();
        }


    }
}
