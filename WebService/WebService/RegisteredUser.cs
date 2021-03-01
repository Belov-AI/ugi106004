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
        private string password;

        public void ChangePassword(string newPassword, string oldPassword)
        {
            if (newPassword == oldPassword && newPassword.Length > 7)
                password = newPassword;
        }
    }
}
