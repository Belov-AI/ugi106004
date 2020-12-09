using System;

namespace RecamanSequence
{
    class Program
    {
        static void Main()
        {
            int m;

            while (true)
            {
                Console.WriteLine("Введите число членов последовательности");

                if (!int.TryParse(Console.ReadLine(), out m))
                {
                    Console.WriteLine("Ошибка ввода\n");
                    continue;
                }

                if (m <= 1)
                {
                    Console.WriteLine("Число членов последовательности должно быть положительным\n");
                    continue;
                }

                break;
            }

            Console.WriteLine();

            foreach(var elem in GetRecamanNumbers(m))
                Console.Write($"{elem} ");

            Console.ReadKey();
        }

        static int[] GetRecamanNumbers(int length)
        {
            int[] recamanNumbers = new int[length];

            for (var i = 1; i < recamanNumbers.Length; i++)
            {
                var number = recamanNumbers[i - 1] - i;

                if (number < 0)
                    number = recamanNumbers[i - 1] + i;

                if (IsInArray(recamanNumbers, number))
                    number = recamanNumbers[i - 1] + i;

                recamanNumbers[i] = number;
            }

            return recamanNumbers;
        }

        static bool IsInArray(int[] array, int number)
        {
            foreach(var elem in array)
                if(elem == number)
                    return true;

            return false;
        }
    }
}
