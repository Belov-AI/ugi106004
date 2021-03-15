using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclidGeometry
{
    public class Triangle
    {
        public Point A;
        public Point B;
        public Point C;

        public readonly Segment AB;
        public readonly Segment AC;
        public readonly Segment BC;

        public Triangle(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;

            AB = new Segment(A, B);
            AC = new Segment(A, C);
            BC = new Segment(B, C);
        }
    }
}
