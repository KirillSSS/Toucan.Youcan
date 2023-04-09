namespace Toucan.Youcan.DTOs
{
    public class SignDTO
    {
        public string Login { get; set; } = "";

        public string Password { get; set; } = "";

        public SignDTO(string log, string pass) 
        {
            Login = log;    Password = pass;
        }
    }
}
