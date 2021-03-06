﻿using System;


namespace Task6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = GetNumber("k");
            var b = GetNumber("m");
            var c = GetNumber("n");

            string answer = "Нет.";

            if (EvaluateLogicalExpression(a, b, c))
                answer = "Да.";

            Console.WriteLine("Верно ли, что хотя бы одно из чисел k, m, или n положительное? " +
                answer);

            Console.ReadKey();
        }

        static bool EvaluateLogicalExpression(int k, int m, int n)
        {
            // хотя бы одно из чисел k, m, или n положительное
            return k > 0 || m > 0 || n > 0; 
        }

        // && - ленивая конъюнкция (И)
        // || - ленивая дизъюнкция (ИЛИ)
        // ! - отрицание (НЕ)
        // ^ - исключающая дизъюнкция

        static int GetNumber(string numberName)
        {
            Console.WriteLine("Введите число " + numberName);
            return int.Parse(Console.ReadLine());
        }
    }
}
