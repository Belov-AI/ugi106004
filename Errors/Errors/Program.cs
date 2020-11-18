using System;


namespace Errors
{
    class Program
    {
        static void Main()
        {

            int a, b;

            Console.WriteLine("Введите число \"a\"");
            if(!int.TryParse(Console.ReadLine(), out a))
                Console.WriteLine("Это не число");
            else
            {
                Console.WriteLine("Введите число \"b\"");
                if(!int.TryParse(Console.ReadLine(), out b))
                    Console.WriteLine("Это не число");

                try
                {
                    Console.WriteLine($"a / b = {a / b}");
                }
                catch
                {
                    Console.WriteLine("На ноль делить нельзя");
                }
            }

            try 
            { 
                Console.WriteLine("Введите строку");
                var str = Console.ReadLine();

                Console.WriteLine($"Пятый символ \'{str[4]}\'");
            }
            catch
            {
                Console.WriteLine("Что-то не так :(");
            }
            



            Console.ReadKey();
        }
    }
}
