using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService
{
    class Program
    {
        static void Main(string[] args)
        {
            var george = new User { Login = "George032" };
            george.PrintInfo();

            var kate = new User("Kate");
            kate.PrintInfo();

            var somebody = new User();
            somebody.PrintInfo();

            User.PrintLogFileName();

            Service.LogIn(george);
            Service.LogIn(kate);
            Service.LogIn(somebody);
            Service.LogIn(george);
            Service.PrintInfo();

            Service.LogOut(somebody);
            Service.LogOut(somebody);
            Service.PrintInfo();

            var regUser = new RegisteredUser("Mike", "12345", "mike@urfu.ru");
            regUser.PrintInfo();


            var vip = new VIPUser("John", "qwertyu", "john@gmail.com", 1234567890123456);

            var admin = new Admin("admin", "admin", "admin@service.ru", 3);

            User[] users = new[] { george, regUser, vip, admin };

            Console.WriteLine();

            foreach (var user in users)
                user.PrintInfo();
            
            //users[2].PrintInfo();


            //((RegisteredUser)users[0]).ChangePassword("12345678", "12345");

            //if(users[1] is RegisteredUser ru)
            //{
            //    ru.ChangePassword("12345678", "12345");
            //}

            Console.ReadKey();
        }
    }
}
