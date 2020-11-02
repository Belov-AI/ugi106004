using System;

namespace Task05._2
{
    class Program
    {
        static void Main()
        {
            var suitcase = "чемодан";

            var demon = suitcase[4] + suitcase.Substring(1, 3) + suitcase[6];
            string sword = "" + suitcase[2] + suitcase[1] + suitcase[0];

            Console.WriteLine($"Вот что получилось: {demon}, {sword}.");

            Console.ReadKey();
        }
    }
}
