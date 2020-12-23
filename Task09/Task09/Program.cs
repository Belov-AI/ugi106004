using System;


namespace Task09
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите строку текста");
            var codes = CreateArray(Console.ReadLine());

            PrintCodes(codes);

            ChangeCodes(codes);
            PrintCodes(codes);

            Console.WriteLine(GetSomeString(codes));

            Console.WriteLine("Введите натуральное число");
            var k = int.Parse(Console.ReadLine());

            PrintCodes(GetShiftedCodes(codes, k));

            Console.ReadKey();

        }

        static int[] CreateArray(string text)
        {
            var result = new int[text.Length];

            for (var i = 0; i < result.Length; i++)
                result[i] = text[i];

            return result;
        }

        static void PrintCodes(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
                if (i < array.Length - 1)
                    Console.Write($"{ConvertToHexString(array[i])}, ");
                else
                    Console.Write($"{ConvertToHexString(array[i])}\n");
        }

        static void ChangeCodes(int[] array)
        {
            for(var i = 0; i < array.Length; i++)
            {
                var symbol = (char)array[i];

                if (char.IsLetter(symbol))
                    if (char.IsUpper(symbol))
                        symbol = char.ToLower(symbol);
                    else
                        symbol = char.ToUpper(symbol);

                array[i] = symbol;
            }                
        }

        static string GetSomeString(int[] array)
        {
            string result = "";

            foreach (var number in array)
                if (number % 2 != 0)
                    result = (char)number + result;

            return result;
        }

        static int[] GetShiftedCodes(int[] array, int shift)
        {
            if (shift < 1)
                throw new ArgumentException("Сдвиг должен быть положительным");

            var result = new int[array.Length];

            for (var i = 0; i < array.Length; i++)
                if (array[i] % 2 == 0)
                    result[i] = array[i] + shift;
                else
                    result[i] = array[i];

            return result;
        }

        static string ConvertToHexString(int number)
        {
            return "0x" + Convert.ToString(number, 16).ToUpper();
        }
    }
}
