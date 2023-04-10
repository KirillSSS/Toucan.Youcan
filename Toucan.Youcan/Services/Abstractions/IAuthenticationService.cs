using Toucan.Youcan.DTOs;
using Toucan.Youcan.Models;

namespace Toucan.Youcan.Services.Abstractions
{
    public interface IAuthenticationService
    {
        public int SignIn(SignDTO user);

        public int SignUp(SignDTO user);

        public SignOutDTO SignInNew(SignInDTO user);
        public SignOutDTO SignUpNew(SignInDTO user);
    }
}
