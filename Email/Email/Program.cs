using System;

namespace Email
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите адрес электронной почты");
            var emailAddress = Console.ReadLine();

            var i = emailAddress.IndexOf('@');
            var emailBox = emailAddress.Substring(0, i);
            var seviceAddress = emailAddress.Substring(i + 1);

            Console.WriteLine($"Ваш почтовый ящик {emailBox} находится на почтовом сервисе {seviceAddress}");

            Console.ReadKey();
        }
    }
}
