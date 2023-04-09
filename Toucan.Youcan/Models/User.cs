namespace Toucan.Youcan.Models
{
    public class User : BaseEntity
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public User(int id, string name, string email, string password) 
        {
            Id = id;    Name = name;    Email = email; Password = password;
        }
    }
}
