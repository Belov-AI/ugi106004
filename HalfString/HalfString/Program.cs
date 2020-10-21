using System;

namespace HalfString
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите строку");
            var str = Console.ReadLine();

            var newStr = str.Substring(str.Length / 2);
            Console.WriteLine("Вторая половина строки: " + newStr);

            Console.ReadKey();
        }
    }
}
