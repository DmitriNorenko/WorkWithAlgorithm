using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkWithAlgorithm;

namespace WorkWithAlgorithm
{
    public class Users
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }
        public Users(string login, string name, bool isPremium)
        {
            Login = login;
            Name = name;
            IsPremium = isPremium;
        }
        public static Users[] UsersInfo()
        {
            Users[] users = new Users[4];
            users[0] = new Users("1", "Иван", false);
            users[1] = new Users("2", "Борис", true);
            users[2] = new Users("3", "Николай", false);
            users[3] = new Users("4", "Александр", true);
            return users;
        }
    }
}
