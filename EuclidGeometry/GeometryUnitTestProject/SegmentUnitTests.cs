using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EuclidGeometry;

namespace GeometryUnitTestProject
{
    [TestClass]
    public class SegmentUnitTests
    {
        [TestMethod]
        public void ConstructorTest()
        {
            var a = new Point(1, 2);
            var b = new Point(-1, 5);

            var s = new Segment(a, b);

            Assert.AreSame(a, s.A);
            Assert.AreSame(b, s.B);           
        }

        [TestMethod]
        public void Lengthtest()
        {
            var s1 = GetSegment(1, 2, 5, -1);

            Assert.AreEqual(5, s1.Length, 1e-8);

            var s2 = GetSegment(1.2, 1.2, 2.2, 2.2);
            Assert.AreEqual(Math.Sqrt(2), s2.Length, 1e-8);
        }

        [TestMethod]
        public void IsContainPointTest()
        {
            var s = new Segment(new Point(1, 1), new Point(5, 3));

            var m1 = new Point(3, 2);
            var m2 = new Point(-1, 0);
            var m3 = new Point(2, 3);

            Assert.IsTrue(s.IsContainPoint(m1));
            Assert.IsFalse(s.IsContainPoint(m2));
            Assert.IsFalse(s.IsContainPoint(m3));
        }

        private Segment GetSegment(double ax, double ay, double bx, double by)
        {
            var a = new Point(ax, ay);
            var b = new Point(bx, by);

            return new Segment(a, b);
        }
    }
}
