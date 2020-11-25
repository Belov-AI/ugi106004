using System;


namespace TryParse
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число");

            double number;

            //var attempt = double.TryParse(Console.ReadLine(), out number);

            //Console.WriteLine($"Удалась попытка? {attempt}\nЧисло равно {number}");

            if (!double.TryParse(Console.ReadLine(), out number))
                Console.WriteLine("Неправильный формат числа");
            else
                Console.WriteLine($"Число равно {number}");
            
            Console.ReadKey();
        }
    }
}
