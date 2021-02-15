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
    }
}
