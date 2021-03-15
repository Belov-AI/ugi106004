using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService
{
    public class VIPUser : RegisteredUser
    {
        private long cardNumber;

        public VIPUser(string login, string pass, string email, long cardNumber) : base(login, pass, email)
        {
            this.cardNumber = cardNumber;
        }
    }
}
