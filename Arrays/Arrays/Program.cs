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

            numbers = new[] { -5, -10 };
               

            Console.ReadKey();
        }

        static void PrintArray(int[] array)
        {
            //for (var i = 0; i < array.Length; i++)
            //    Console.Write($"{array[i]} ");

            foreach(var elem in array)
                Console.Write($"{elem} ");

            Console.WriteLine();
        }
    }
}
