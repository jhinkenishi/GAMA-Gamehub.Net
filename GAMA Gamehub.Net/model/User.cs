using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMA_Gamehub.Net.model
{
    public class User
    {
        private int id;
        private string name;
        private string email;
        private string username;
        private string password;
        private int loginStatus;
        private string userType;

        public User( string name, string email, string username, string password, int loginStatus, string userType)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Username = username;
            this.Password = password;
            this.LoginStatus = loginStatus;
            this.UserType = userType;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int LoginStatus { get => loginStatus; set => loginStatus = value; }
        public string UserType { get => userType; set => userType = value; }
    }
}
