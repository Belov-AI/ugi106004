using System;


namespace HarmonicalSeries
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число \"a\"");
            var a = double.Parse(Console.ReadLine());


            long n = 1;
            double sum = 0;
            bool flag = true;

            do
            {
                sum += 1.0 / n;

                if(n == long.MaxValue)
                {
                    Console.WriteLine("\"n\" слишком большое");
                    flag = false;
                    break;
                }

                n++;

                if (n % 1000000 == 0)
                    Console.Write(".");

            } while (sum <= a);

            if(flag)
                Console.WriteLine($"\nМинимальное \"n\" равно {n - 1}");

            Console.ReadKey();
        }
    }
}
