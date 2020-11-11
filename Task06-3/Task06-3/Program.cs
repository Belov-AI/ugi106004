using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06_3
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void GetCoordinates(string position, out int x, out int y)
        {
            x = (int)position[0] - 0x60;
            y = int.Parse(position[1].ToString());
        }
    }
}
