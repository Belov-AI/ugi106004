using System;

namespace ArraysAndLoops
{
    class Program
    {
        static void Main()
        {
            int[] numbers = new[] { 1, 4, -3, 8, 15 };
            PrintArray(numbers);

            ReplaceWithSquares(numbers);
            PrintArray(numbers);

            var rests = GetRests(numbers, 3);

            PrintArray(rests);
            PrintArray(numbers);

            for (var i = 0; i < 5; i++)
            {
                if (i == 3)
                    break;

                if (i % 2 != 0)
                    continue;

                Console.WriteLine(i);
            }

            var number = 1;

            var fact = 1;

            while (fact <= int.MaxValue / number)
            {
                fact *= number;
                Console.WriteLine(fact);
                number++;
            }

            var max = int.MinValue;

            while (true)
            {
                Console.WriteLine("Введите следующее целое число (Enter - конец ввода)");
                
                var input = Console.ReadLine();

                if (input.Length == 0)
                    break;

                var x = int.Parse(input);

                if (x > max)
                    max = x;
            }

            Console.WriteLine($"Наибольшее введенное число: {max}");

            Console.ReadKey();
        }

        static int[] GetRests(int[] array, int n)
        {
            var result = new int[array.Length];

            for (var i = 0; i < result.Length; i++)
                result[i] = array[i] % n;

            return result;
        }

        static void ReplaceWithSquares(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
                array[i] *= array[i];
        }

        static void PrintArray(int[] array)
        {
            foreach (var elem in array)
                Console.Write($"{elem} ");

            Console.WriteLine();
        }

    }
}
