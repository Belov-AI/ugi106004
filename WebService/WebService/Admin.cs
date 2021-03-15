using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService
{
    public sealed class Admin : RegisteredUser
    {
        public int Accesslevel;

        public Admin(string login, string pass, string email, int level) : base(login, pass, email)
        {
            Accesslevel = level;
        }

        private bool CheckPassword(string pass)
        {
            return password == pass;
        }
    }
}
