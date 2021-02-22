using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService
{
    public class User
    {
        static readonly string logFileName;

        public string Login { get; set; }

        public User(string login)
        {
            Login = login;
        }

        public User() : this("Anonymous") { }

        static User()
        {
            logFileName = $"log{DateTime.Now.ToShortDateString()}.txt";
        }

        ~User()
        {
            Console.WriteLine($"Пользователь {Login} удален");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Пользователь {Login}");
        }

        public static void PrintLogFileName()
        {
            Console.WriteLine($"Файл журнала: {logFileName}");
        }
    }
}
