using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Durak.BL
{
    public class User
    {
        public string Login;

        public User(string login)
        {
            Login = login;
        }

        public override bool Equals(object obj)
        {
            if (obj is User user)
            {
                return user.Login.Equals(Login);
            }
            return false;
        }
    }
}
