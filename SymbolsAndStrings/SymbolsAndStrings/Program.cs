using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymbolsAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ");
            char ch = Console.ReadKey().KeyChar;

            Console.WriteLine($"\nСимвол \'{ch}\'. Код 0x{(int)ch:X}");

            int nextCharCode = (int)ch + 1;
            char nextChar = (char)nextCharCode;
            Console.WriteLine($"Следующий символ \'{nextChar}\'. Код 0x{nextCharCode:X}");

            Console.ReadKey();
        }
    }
}
