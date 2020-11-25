using System;

namespace Chessboard
{
    class Program
    {
        static char horizontalLine = (char)0x2500;
        static char verticalLine = (char)0x2502;
        static char topLeftCorner = (char)0x250C;
        static char topRightCorner = (char)0x2510;
        static char bottomLeftConer = (char)0x2514;
        static char bottomRightConer = (char)0x2518;

        static char square = (char)0x2588;

        static ConsoleColor white = ConsoleColor.Yellow;
        static ConsoleColor black = ConsoleColor.DarkRed;

        static void Main()
        {
            string input;
            int boardSize;

            while (true)
            {
                Console.WriteLine("Ведите размер шахматной доски (Enter - выход)");
                input = Console.ReadLine();

                if (input == "") break;

                if(!int.TryParse(input, out boardSize))
                {
                    Console.WriteLine("Ошибка ввода\n");
                    continue;
                }

                if(boardSize < 1 || boardSize > 26)
                {
                    Console.WriteLine("Размер доски должен быть от 1 до 26\n");
                    continue;
                }

                PrintChessboard(boardSize);
            }
        }

        static void PrintChessboard(int size)
        {
            PrintHeader(size);
            PrintLine(size, horizontalLine, topLeftCorner, topRightCorner);

            ConsoleColor even, odd;

            if(size % 2 == 0)
            {
                even = white;
                odd = black;
            }
            else
            {
                even = black;
                odd = white;
            }


            for(var i = 0; i < size; i++)
            {
                var template = $"{{0, {size.ToString().Length}}}" + verticalLine;
                Console.Write(template, size - i);

                for (var j = 0; j < size; j++)
                    if ((i + j) % 2 == 0)
                        PrintSquare(even);
                    else
                        PrintSquare(odd);

                Console.WriteLine(verticalLine + (size - i).ToString());
            }

            PrintLine(size, horizontalLine, bottomLeftConer, bottomRightConer);
            PrintHeader(size);

            Console.WriteLine();
        }

        static void PrintHeader(int size)
        {
            Console.Write(new string(' ', size.ToString().Length + 1));
            
            for (var i = 0; i < size; i++)
                Console.Write((char)((int)'a' + i));

            Console.WriteLine();
        }

        static void PrintLine(int size, char line, char firstCorner, char lastCorner)
        {
            var str = new string(' ', size.ToString().Length) + firstCorner
                + new string(line, size) + lastCorner;
            Console.WriteLine(str);
        }

        static void PrintSquare(ConsoleColor color)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(square);
            Console.ForegroundColor = oldColor;
        }
    }
}
