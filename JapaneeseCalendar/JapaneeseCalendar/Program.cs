using System;
using System.Security.Cryptography.X509Certificates;

namespace JapaneeseCalendar
{
    class Program
    {
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Введите год н. э.(Enter - выход)");
                var input = Console.ReadLine();

                if (input == "")
                    break;

                var year = int.Parse(input);

                var yearInCycle = (year - 1984) % 60;

                if (yearInCycle < 0)
                    yearInCycle += 60;

                var color = yearInCycle / 12;
                var animal = yearInCycle % 12;

                Console.WriteLine($"{year} — год {GetColor(color)}{GetAnimal(animal)}\n");
            }
        }

        static string GetColor(int color)
        {
            switch (color)
            {
                case 0:
                    return "зеленo";
                case 1:
                    return "краснo";
                case 2:
                    return "желтo";
                case 3:
                    return "белo";
                default:
                    return "черно";
            }
        }

        static string GetAnimal(int animal)
        {
            switch (animal)
            {
                case 0:
                    return "й крысы";
                case 1:
                    return "й коровы";
                case 2:
                    return "го тигра";
                case 3:
                    return "го зайца";
                case 4:
                    return "го дракона";
                case 5:
                    return "й змеи";
                case 6:
                    return "й лошади";
                case 7:
                    return "й овцы";
                case 8:
                    return "й обезьяны";
                case 9:
                    return "й курицы";
                case 10:
                    return "й собаки";
                default:
                    return "й свиньи";
            }
        }
    }
}
