using System;

namespace Arrays
{
    class Program
    {
        static void Main()
        {
            int[] numbers;

            Console.WriteLine("Введите число элементов массива");

            var n = int.Parse(Console.ReadLine());
            numbers = new int[n];

            for (var i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Введите элемент");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            PrintArray(numbers);
            Array.Sort(numbers);
            PrintArray(numbers);


            PrintIndexOf(numbers, 2);
            PrintIndexOf(numbers, 5);


            var newNumbers = (int[])numbers.Clone();

            PrintArray(newNumbers);
            newNumbers[0] = 111;
            PrintArray(newNumbers);
            PrintArray(numbers);

            newNumbers[1] = 222;
            newNumbers[2] = 333;
            newNumbers[3] = 444;
            newNumbers[4] = 555;
            Array.Copy(newNumbers, numbers, newNumbers.Length);
            PrintArray(numbers);

            double[] array = new double[n];
            Array.Copy(numbers, array, numbers.Length);
            PrintArray(array);

            Console.WriteLine();

            var matrix = new int[3, 4];

            var rnd = new Random();

            for (var i = 0; i < matrix.GetLength(0); i++)
                for (var j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = rnd.Next(100);

            PrintMatrixArray(matrix);

            var table = new int[4][];
            table[0] = new int[3];
            table[1] = new int[2];
            table[2] = new int[3];
            table[3] = new int[4];

            //заполним эти массивы случайными числами от 0 до 9

            Console.WriteLine($"Число массивов в массиве массивов: {table.Length}");

            for (var i = 0; i < table.Length; i++)
                for (var j = 0; j < table[i].Length; j++)
                    table[i][j] = rnd.Next(10);

            PrintArrayOfIntArrays(table);

            var cities = new[] {
                new[] {"Москва", "Екатеринбург", "Новосибирск", "Санкт-Петербург"},
                new[] {"Париж", "Лондон", "Рим"},
                new[] {"Пекин", "Токио", "Стамбул"},
                };

            PrintArrayOfStringArrays(cities);

            Console.ReadKey();
        }

        static void PrintArray(int[] array)
        {
            foreach(var elem in array)
                Console.Write($"{elem}, ");

            Console.Write("\b\b ");

            Console.WriteLine();
        }

        static void PrintArray(double[] array)
        {
            foreach (var elem in array)
                Console.Write($"{elem}, ");

            Console.Write("\b\b ");

            Console.WriteLine();
        }

        static void PrintIndexOf(int[] array, int number)
        {
            var index = Array.BinarySearch(array, number);

            if (index < 0)
                Console.WriteLine($"Элемент \"{number}\" не найден");
            else
                Console.WriteLine($"Элемент \"{number}\" имеет индекс {index}");
        }

        static void PrintMatrixArray(int[,] matrix)
        {
            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                    Console.Write($"{matrix[i, j],2} ");

                Console.WriteLine();
            }
                
        }

        static void PrintArrayOfIntArrays(int[][] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = 0; j < array[i].Length; j++)
                    Console.Write($"{array[i][j]} ");

                Console.WriteLine();
            }                    
        }

        static void PrintArrayOfStringArrays(string[][] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = 0; j < array[i].Length; j++)
                    Console.Write($"{array[i][j]} ");

                Console.WriteLine();
            }
        }
    }
}
