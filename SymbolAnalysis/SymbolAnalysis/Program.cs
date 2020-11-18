using System;

namespace SymbolAnalysis
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Введите символ (Enter - выход)");
                var consoleKey = Console.ReadKey().KeyChar;

                if ((int)consoleKey == (int)ConsoleKey.Enter)
                    break;
                Console.WriteLine();

                if (char.IsUpper(consoleKey))
                    Console.WriteLine("Заглавная буква");
                else if (char.IsLower(consoleKey))
                    Console.WriteLine("Прописная буква");
                else if (char.IsDigit(consoleKey))
                    Console.WriteLine("Цифра");
                else if (char.IsWhiteSpace(consoleKey))
                    Console.WriteLine("Пробел");
                else if (char.IsPunctuation(consoleKey))
                    Console.WriteLine("Знак пунктуации");
                else
                    Console.WriteLine("Специальный символ");

                Console.WriteLine();
            }            
        }
    }
}
