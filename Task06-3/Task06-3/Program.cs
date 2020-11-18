using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию белого ферзя");
            var whiteQueenPosition = Console.ReadLine();
            Console.WriteLine("Введите позицию черного короля");
            var blackKingPosition = Console.ReadLine();

            if (CheckPosition(whiteQueenPosition, blackKingPosition))
            {
                Console.WriteLine("Введите ход белого ферзя");
                var whiteQueenMove = Console.ReadLine();
                if (CanQueenMakeSafeMove(whiteQueenPosition, whiteQueenMove, blackKingPosition))
                    Console.WriteLine("Ферзь может ходить");
                else
                    Console.WriteLine("Ферзь не может ходить");
            }
            else
                Console.WriteLine("Введенные позиции некорректны");

            Console.ReadKey();
        }

        static void GetCoordinates(string position, out int x, out int y)
        {
            x = (int)position[0] - 0x60;
            y = int.Parse(position[1].ToString());
        }

        static bool CanQueenMakeMove(string start, string end)
        {
            if (start == end)
                return false;

            int startX, startY, endX, endY;
            GetCoordinates(start, out startX, out startY);
            GetCoordinates(end, out endX, out endY);

            return startX == endX || startY == endY || Math.Abs(endX - startX) == Math.Abs(endY - startY);
        }

        static bool CanKingMakeMove(string start, string end)
        {
            if (start == end)
                return false;

            int startX, startY, endX, endY;
            GetCoordinates(start, out startX, out startY);
            GetCoordinates(end, out endX, out endY);

            return Math.Abs(endX - startX) <= 1 && Math.Abs(endY - startY) <= 1;
        }

        static bool CheckPosition(string whitePos, string blackPos)
        {
            return whitePos != blackPos && !CanQueenMakeMove(whitePos, blackPos);// && !CanKingMakeMove(blackPos, whitePos);
        }

        static bool CanQueenMakeSafeMove(string queenStartPos, string queenEndPos, string kingPos)
        {
            return CanQueenMakeMove(queenStartPos, queenEndPos) && !CanKingMakeMove(kingPos, queenEndPos);
        }
    }
}
