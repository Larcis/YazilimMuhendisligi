using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazılımMuhendisligi
{
    public enum UserType { AG, YSP }
    public class User
    {
        private string userName;
        private string password;
        private UserType type;

        public string Username { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public UserType Type { get => type; set => type = value; }
        public User(string username, string password, UserType type = UserType.AG)
        {
            Username = username;
            Password = password;
            Type     = type;
        }

        
    }
}
