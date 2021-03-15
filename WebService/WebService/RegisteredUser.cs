using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService
{
    public class RegisteredUser : User
    {
        public string Email;
        protected string password;

        public RegisteredUser(string login) : base(login) { }

        public RegisteredUser() : base() { }

        public RegisteredUser(string login, string pass, string email) : base(login)
        {
            password = pass;
            Email = email;
        }

        public void ChangePassword(string newPassword, string oldPassword)
        {
            if (password == oldPassword && newPassword.Length > 7)
                password = newPassword;
        }
    }
}
