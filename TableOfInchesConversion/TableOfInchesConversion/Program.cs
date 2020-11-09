using System;

namespace TableOfInchesConversion
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите первое число в таблице (в дюймах)");
            var start = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите шаг таблицы (в дюймах)");
            var step = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество строк в таблице");
            var numberOfLines = int.Parse(Console.ReadLine());

            //Шапка таблицы
            Console.WriteLine("\x250C" + new String((char)0x2500, 7) + "\x252C" + new String((char)0x2500, 8) + "\x2510");
            Console.WriteLine("\x2502 дюймы \x2502   см   \x2502");
            Console.WriteLine("\x251C" + new String((char)0x2500, 7) + "\x253C" + new String((char)0x2500, 8) + "\x2524");

            var valIninches = start;

            for (var i = 0; i < numberOfLines; i++)
            {
                var valInCm = valIninches * 2.54;
                Console.WriteLine($"\x2502 {valIninches,5:F2} \x2502 {valInCm,6:F2} \x2502");
                valIninches += step;
            }

            
            //Низ таблицы
            Console.WriteLine("\x2514" + new String((char)0x2500, 7) + "\x2534" + new String((char)0x2500, 8) + "\x2518");

            Console.ReadKey();
        }
    }
}
