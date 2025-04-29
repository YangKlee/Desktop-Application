using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_vocabulary
{
    internal class User
    {
        public string userName { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public User(string user, string email,string password)
        {
            this.userName = user;
            this.email = email;
            this.password = password;
        }

    }
}
