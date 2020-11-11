using System;


namespace Return
{
    class Program
    {
        static void Main()
        {
            var x = DoubleOrTriple(1);
            PrintInfo(x);

            x = DoubleOrTriple(2);
            PrintInfo(x);

            Console.ReadKey();
        }

        static void PrintInfo(int x)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine($"Число {x} четное");
                return;
            }
                            
            Console.WriteLine($"Число {x} нечетное");
        }

        static int DoubleOrTriple(int x)
        {
           if(x % 2 != 0)
                return 2 * x;

           return 3 * x;
        }
    }
}
