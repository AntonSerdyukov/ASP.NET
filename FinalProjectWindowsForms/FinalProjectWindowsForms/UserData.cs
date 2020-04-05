using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectWindowsForms
{
    class UserData
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public UserData(string login,string password)
        {
            Login = login;
            Password = password;
        }

    }
}
