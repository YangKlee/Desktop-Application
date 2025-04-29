using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_vocabulary
{
    internal interface UserIDAO
    {
        
        void addUser(User newUser);
        bool verifyUser(string userName, string password);
    }
}
