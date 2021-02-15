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

            Console.ReadKey();

        }
    }
}
