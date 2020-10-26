using System;
using System.Security.Cryptography;

namespace Logic
{
    class Program
    {
        static void Main()
        {
            var x = 3;
            var y = 5;

            bool expression = x < y;

            Console.WriteLine(expression);
            Console.WriteLine(y <= x);
            expression = true;
            Console.WriteLine(expression);

            Console.WriteLine();
            var a = 'b';
            var b = 'Z';
            //Console.WriteLine($"\'{a}\' — код 0x{(int)a:X}");
            //Console.WriteLine($"\'{b}\' — код 0x{(int)b:X}");
            Console.WriteLine(a < b);

            Console.WriteLine();
            Console.WriteLine("abc" == "ab");

            Console.WriteLine(x > 0 && x < 10);
            Console.WriteLine(x != 0 && (y / x) * x == y);

            Console.WriteLine(x == 0 || (y / x) * x == y);

            double u = Math.PI;

            double v = Math.Sqrt((u + 100000) * (u + 100000)) - 100000;

            Console.WriteLine($"u = {u}");
            Console.WriteLine($"v = {v}");

            //Console.WriteLine(u == v);
            Console.WriteLine(Math.Abs(u - v) < 1e-9);

            Console.WriteLine($"{Convert.ToString(x, 2), 3}");
            Console.WriteLine($"{Convert.ToString(y, 2), 3}");
            var xAndY = x & y;
            Console.WriteLine($"{Convert.ToString(xAndY, 2),3} — это {xAndY}");
            var xOrY = x | y;
            Console.WriteLine($"{Convert.ToString(xOrY, 2),3} — это {xOrY}");
            var xXorY = x ^ y;
            Console.WriteLine($"{Convert.ToString(xXorY, 2),3} — это {xXorY}");
            var notX = ~x;
            Console.WriteLine($"{Convert.ToString(notX, 2),3} — это {notX}");

            Console.ReadKey();
            
        }
    }
}
