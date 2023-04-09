using Toucan.Youcan.DTOs;
using Toucan.Youcan.Models;
using Toucan.Youcan.Models.Options;
using Toucan.Youcan.Services.Abstractions;

namespace Toucan.Youcan.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public int SignIn(SignDTO user)
        {
            if (user == null || !CheckUser(user.Login, user.Password, out var ID))
                throw new ArgumentException("No such user");
            else
                return ID;
        }

        public int SignUp(SignDTO user)
        {
            if (user == null || !RegUser(user.Login, user.Password, out var ID))
                throw new ArgumentException("No such user");
            else
                return ID;
        }

        private bool CheckUser(string login, string password, out int ID)
        {
            var temp = 1;

            List<User> users = new List<User>
            {
                new User(temp++, "John", "john@example.com", "password1" ),
                new User(temp++, "Jane", "jane@example.com", "password2" ),
                new User(temp++, "Nude", "nude@example.com", "password3" ),
                new User(temp++, "Oleg", "oleg@example.com", "hello_olleh" ),
                new User(temp++, "Python", "python@example.com", "pass4" ),
            };

            System.Diagnostics.Debug.WriteLine(login + " " + password + " " + users[1].Email + " " + users[1].Password);

            foreach (var user in users)
            {
                if (user.Email == login && user.Password == password)
                {
                    ID = user.Id;
                    return true;
                }
            }

            ID = -1;
            return false;
        }

        private bool RegUser(string login, string password, out int ID)
        {
            ID = -1;
            return false;
        }
    }
}
