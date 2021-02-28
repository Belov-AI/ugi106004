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
    }
}
