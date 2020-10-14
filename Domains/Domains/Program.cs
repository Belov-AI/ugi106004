using System;

namespace Domains
{
    class Program
    {
        static int y = 2;

        static void Main()
        {
            var x = 3;
            PrintSmth(x + y);

            Console.ReadKey();
        }

        static void PrintSmth(int n)
        {
            int z = 4;

            {
                var w = 5;
                z += w;
            }

            Console.WriteLine(n * y + z);
        }
    }
}
