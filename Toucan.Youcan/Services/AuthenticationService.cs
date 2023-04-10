using Toucan.Youcan.DTOs;
using Toucan.Youcan.Models;
using Toucan.Youcan.Models.Options;
using Toucan.Youcan.Data;
using Toucan.Youcan.Data.Entities;
using Toucan.Youcan.Data.Repositories;
using Toucan.Youcan.Data.Abstraction;
using Toucan.Youcan.Services.Abstractions;

namespace Toucan.Youcan.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private IUsersRepository _userRepository;
        public AuthenticationService(IUsersRepository usersRepository)
        {
            _userRepository = usersRepository;
        }
        public int SignIn(SignDTO user)
        {
            if (user == null || !CheckUser(user.Login, user.Password, out var ID))
                throw new ArgumentException("No such user");
            else
                return ID;
        }
        public SignOutDTO SignInNew(SignInDTO user)
        {
            var userOut = _userRepository.GetByMail(user.email);
            var signOut = new SignOutDTO();
            if (userOut == null)
            {
                signOut.message = "No such user";
                return signOut;
            }
            else if (userOut.password.Equals(user.password))
            {
                signOut.message = "Success";
                signOut.user = new UserDTO();
                signOut.user.email = user.email;
                signOut.user.id = userOut.id.ToString();
                return signOut;
            }
            else
            {
                signOut.message = "Incorrect password";
                return signOut;
            }
        }
        public SignOutDTO SignUpNew(SignInDTO user)
        {
            var userOut = _userRepository.GetByMail(user.email);
            var signOut = new SignOutDTO();
            if (userOut == null)
            {
                var userNew = new Users();
                userNew.mail = user.email;
                userNew.password = user.password;
                //var id = new Random().Next(1, 1000000);
                //while (true)
                //{
                //    var t = _userRepository.Get(id);
                //    if (t == null)
                //        break;
                //    id = new Random().Next(1, 1000000);                    
                //}
                //userNew.id = id;
                var id = _userRepository.Add(userNew);
                _userRepository.SaveChanges();
                signOut.message = "Success";
                signOut.user = new UserDTO();
                signOut.user.email = user.email;
                signOut.user.id = _userRepository.GetByMail(user.email).id.ToString();
                return signOut;
            }
            else
            {

                signOut.message = "Exist User";
                return signOut;
            }
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
