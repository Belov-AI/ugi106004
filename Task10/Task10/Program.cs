using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 0, n = 0;

            var tryAgain = true;

            while(tryAgain)
            {
                Console.WriteLine("Введите число строк (m)");
                var input = Console.ReadLine();

                if(int.TryParse(input, out m) && m >= 5 && m <= 20 )
                {
                    while (true)
                    {
                        Console.WriteLine("Введите число столбцов (n)");
                        input = Console.ReadLine();

                        if (int.TryParse(input, out n) && n >= 5 && n <= 20)
                        {
                            tryAgain = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ошибка ввода\n");
                            continue;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка ввода\n");
                    continue;
                }
            }

            var rnd = new Random();

            var table = new int[m, n];

            for (var i = 0; i < table.GetLength(0); i++)
                for (var j = 0; j < table.GetLength(1); j++)
                    table[i, j] = rnd.Next(0, 100);

            PrintTable(table);

            var index = GetIndexOfOddColumn(table);

            if (index < 1)
                Console.WriteLine("Столбец не найден");
            else
                Console.WriteLine($"Индекс столбца из нечетных элементов: {index}.");

            var averages = GetAverageByRow(table);

            for (var i = 0; i < averages.Length; i++)
                Console.WriteLine($"Строка: {i,2} Среднее: {averages[i]:F3}");

            Console.ReadKey();
        }

        static void PrintTable(int[,] t)
        {
            for(var i = 0; i < t.GetLength(0); i++)
            {
                for (var j = 0; j < t.GetLength(1); j++)
                    Console.Write($"{t[i, j], 2} ");

                Console.WriteLine();
            }
        }

        static int GetIndexOfOddColumn(int[,] t)
        {
            int j;

            for(j = 0; j < t.GetLength(1); j++)
            {
                int i;

                for(i = 0; i < t.GetLength(0); i++)
                    if (t[i, j] % 2 == 0)
                        break;

                if (i == t.GetLength(0))
                    break;
            }

            if (j == t.GetLength(1))
                return -1;
            else
                return j;
        }

        static double[] GetAverageByRow(int[,] t)
        {
            var result = new double[t.GetLength(0)];

            for(var i = 0; i < t.GetLength(0); i++)
            {
                var s = 0.0;

                for (var j = 0; j < t.GetLength(1); j++)
                    s += t[i, j];

                result[i] = s / t.GetLength(1);
            }

            return result;
        }
    }
}
