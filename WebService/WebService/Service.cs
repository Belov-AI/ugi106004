using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService
{
    public static class Service
    {
        private static List<User> users;

        static Service()
        {
            users = new List<User>();
            Console.WriteLine("> служба запущена");
        }

        public static void LogIn(User user)
        {
            if (!users.Contains(user))
            {
                users.Add(user);
                Console.WriteLine($"> присоединился пользователь {user.Login}");
            }
        }

        public static void LogOut(User user)
        {
            if (users.Remove(user))
                Console.WriteLine($"> отсоединился пользователь {user.Login}");
        }

        public static void PrintInfo()
        {
            Console.WriteLine("\n> пользователи сервиса:");
            
            foreach (var user in users)
                Console.Write($"{user.Login}, ");

            Console.WriteLine("\b\b. ");
            Console.WriteLine($"> всего онлайн: {users.Count}\n");
        }
    }
}
