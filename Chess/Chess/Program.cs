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

        //static char square = (char)0x2588;

        static ConsoleColor white = ConsoleColor.Yellow;
        static ConsoleColor black = ConsoleColor.DarkRed;
        static ConsoleColor chessPiece = ConsoleColor.Black;

        static char[,] board = new char[8, 8];

        static void Main()
        {
            InitializeGame();
            PrintChessboard();

            bool player = true; //true - белые, false - черные

            while (true)
            {
                if (player)
                    Console.WriteLine("Ход белых:");
                else
                    Console.WriteLine("Ход черных:");

                var move = Console.ReadLine();
                if (move == "") break;

                MakeMove(move);
                PrintChessboard();

                player ^= true; //смена очередности хода
            }

            Console.ReadKey();
        }

        static void InitializeGame()
        {
            var initialPosition = new[] { 'R', 'N', 'B', 'Q', 'K', 'B', 'N', 'R' };

            for(var i = 0; i < board.GetLength(0); i++)
                for(var j = 0; j < board.GetLength(1); j++)
                    switch (i)
                    {
                        case 0:
                            board[i, j] = char.ToLower(initialPosition[j]);
                            break;
                        case 1:
                            board[i, j] = 'p';
                            break;
                        case 6:
                            board[i, j] = 'P';
                            break;
                        case 7:
                            board[i, j] = initialPosition[j];
                            break;
                        default:
                            board[i, j] = ' ';
                            break;
                    }
        }

        static void MakeMove(string move)
        {
            int iStart, jStart, iEnd, jEnd;

            GetIndexes(move.Substring(0, 2), out iStart, out jStart);
            GetIndexes(move.Substring(3, 2), out iEnd, out jEnd);

            board[iEnd, jEnd] = board[iStart, jStart];
            board[iStart, jStart] = ' ';
        }

        static void GetIndexes(string position, out int i, out int j)
        {
            i = 8 - int.Parse(position[1].ToString());
            j = (int)position[0] - 0x61;
        }

        static void PrintChessboard()
        {
            var size = 8;

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
                        PrintSquare(board[i,j], even);
                    else
                        PrintSquare(board[i,j], odd);

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

        static void PrintSquare(char square, ConsoleColor squareColor)
        {
            var oldForegroundColor = Console.ForegroundColor;
            Console.ForegroundColor = chessPiece;

            var oldBackgroundColor = Console.BackgroundColor;
            Console.BackgroundColor = squareColor;

            Console.Write(square);

            Console.ForegroundColor = oldForegroundColor;
            Console.BackgroundColor = oldBackgroundColor;
        }
    }
}
