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


            //var newNumbers = (int[])numbers.Clone();

            //PrintArray(newNumbers);
            //newNumbers[0] = 111;
            //PrintArray(newNumbers);
            //PrintArray(numbers);

            //newNumbers[1] = 222;
            //newNumbers[2] = 333;
            //newNumbers[3] = 444;
            //newNumbers[4] = 555;
            //Array.Copy(newNumbers, numbers, newNumbers.Length);
            //PrintArray(numbers);

            //double[] array = new double[n];
            //Array.Copy(numbers, array, numbers.Length);
            //PrintArray(array);

            Console.WriteLine();

            var matrix = new int[3, 4];

            var rnd = new Random();

            for (var i = 0; i < matrix.GetLength(0); i++)
                for (var j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = rnd.Next(0, 100);

            PrintMatrixArray(matrix);

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
    }
}
