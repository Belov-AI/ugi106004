using System;

namespace StringsAndCharacters
{
    class Program
    {
        static void Main()
        {
            char ch = 'я';
            Console.WriteLine(ch);

            var a  = char.ToUpper(ch);
            Console.WriteLine(a);

            Console.WriteLine(char.IsLetter(a));
            Console.WriteLine(char.IsDigit(a));

            string s = "abcd";
            Console.WriteLine(s);
            Console.WriteLine(s.ToUpper());

            Console.WriteLine("Привет всем!\nКакая хорошая погода!");
            Console.WriteLine("Привет всем!\rКакая хорошая погода!");
            Console.WriteLine("Привет всем!\bКакая хорошая погода!");
            //Console.WriteLine("Привет всем!\aКакая хорошая погода!");
            Console.WriteLine("\"Привет всем! Какая хорошая погода!\"");
            Console.WriteLine("Символ \'\x0426\'");

            Console.WriteLine(@"""C:\Windows\Program Files\Office365\Word.exe""");

            double num1 = 2.58975987;
            double num2 = -0.056;

            string str = string.Format("x = {0, 6:F4} y = {1:G}", num1, num2);
            //Console.WriteLine(str);

            //Console.WriteLine("x = {0, 6:P} y = {1:E}", num1, num2);
            Console.WriteLine($"x = {num1, 6:P} y = {num2:E}",);

            int d = 125;
            Console.WriteLine("{0} в шестадцатеричной системе счисления: {0:X}", d);

            DateTime moment = DateTime.Now;
            Console.WriteLine("{0:HH:mm:ss dd.MM.yyyy}", moment);

            Console.ReadKey();
        }
    }
}
