using System;

namespace SophieGermainSequence
{
    class Program
    {
        static void Main()
        {
            int m;

            while (true)
            {
                Console.WriteLine("Введите число членов последовательности");

                if(!int.TryParse(Console.ReadLine(), out m))
                {
                    Console.WriteLine("Ошибка ввода\n");
                    continue;
                }

                if(m <= 1)
                {
                    Console.WriteLine("Число членов последовательности должно быть положительным\n");
                    continue;
                }

                break;
            }

            Console.WriteLine();

            var current = 1;

            for(var i = 0; i < m; i++)
            {
                current = GetNextSophieGermainPrimeNumber(current);
                Console.Write($"{current} ");
            }

            Console.ReadKey();
        }

        static int GetNextSophieGermainPrimeNumber(int number)
        {
            while (true)
            {
                number++;
                if (IsPrime(number) && IsPrime(2 * number + 1))
                    return number;
            }

        }

        static bool IsPrime(int number)
        {
            var result = true;
            var bound = Math.Sqrt(number);

            for (var d = 2; d <= bound; d++)
            {
                if(number % d == 0)
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
    }
}
