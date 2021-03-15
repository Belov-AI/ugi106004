using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclidGeometry
{
    public static class Geometry
    {
        public static Segment CreateSegment(Point a, Point b)
        {
            var segment = new Segment(a, b);

            return segment;
        }

        public static bool IsPointInsideSegment(Point p, Segment s)
        {
            return p.IsInsideSegment(s);
        }

        public static Triangle CreateTriangle(Point a, Point b, Point c)
        {
            var t = new Triangle(a, b, c);

            if (t.A.IsInsideSegment(t.BC) || t.B.IsInsideSegment(t.AC) || t.C.IsInsideSegment(t.AB))
                throw new ArgumentException("Вершины треугольника не должны лежать на одной прямой");

            return t;
        }
    }
}
