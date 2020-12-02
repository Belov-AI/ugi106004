using System;

namespace FibonacciSequence
{
    class Program
    {
        static ulong preprevious, previous, current;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите число членов последовательности (Enter — отказ)");
                var input = Console.ReadLine();

                if (input.Length < 1)
                    break;

                int n;

                if(!int.TryParse(input, out n))
                {
                    Console.WriteLine("Ошибка ввода\n");
                    continue;
                }

                if(n < 1)
                {
                    Console.WriteLine("Число членов последовательности должно быть положительным\n");
                    continue;
                }

                PrintFibonacciSequence(n);

                Console.WriteLine();
            }

            while (true)
            {
                Console.WriteLine("Введите нижнюю границу (Enter — отказ)");
                var input = Console.ReadLine();

                if (input == string.Empty)
                    break;

                int m;

                if (!int.TryParse(input, out m))
                {
                    Console.WriteLine("Ошибка ввода\n");
                    continue;
                }

                PrintMininmalMember(m);

                Console.WriteLine();
            }
        }

        static void PrintFibonacciSequence(int n)
        {
            Initialize();

            for(var i = 0; i < n; i++)
            {
                var next = GetNext("Следующие члены последовательности очень большие");

                if (next == 0)
                    return;
                
                Console.Write($"{next} ");
            }

            Console.WriteLine();
        }

        static void PrintMininmalMember(int bound)
        {
            Initialize();

            ulong next;

            do
            {
                next = GetNext("Следующие граница очень большая");
                if (next == 0)
                    return;
            } while (next <= (ulong)bound) ;

                Console.WriteLine($"Член последовательности, больший {bound} равен {next}");
        }

        static ulong GetNext(string message)
        {
            preprevious = previous;
            previous = current;

            try
            {
                checked
                {
                    current = previous + preprevious;
                }
            }

            catch
            {
                Console.WriteLine(message);
                return 0;
            }

            return current;
        }

        static void Initialize()
        {
            preprevious = 0;
            previous = 1;
            current = 0;
        }
    }
}
