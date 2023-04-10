using Azure.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text.Json;
using Toucan.Youcan.DTOs;
using Toucan.Youcan.Services;
using Toucan.Youcan.Services.Abstractions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Toucan.Youcan.Controllers
{
    [Route("user/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        //[HttpGet("signIn")]
        //public string SignIn(/*SignInDTO user*/string login, string hashedPassword)
        //{
        //    var user = new SignDTO(login, hashedPassword);

        //    try
        //    {
        //        return _authenticationService.SignIn(user) + "";
        //    }
        //    catch (Exception ex)
        //    {
        //        return ex.Message;
        //    }
        //}
        [HttpGet("signIn")]
        public string SignIn(string email, string password)
        {
            var user = new SignInDTO();
            user.email = email;
            user.password = password;
            try
            {
                return JsonSerializer.Serialize(_authenticationService.SignInNew(user));
            }
            catch (Exception ex)
            {
                var ret = new SignOutDTO();
                ret.message = ex.Message;
                return JsonSerializer.Serialize(ret);
            }
        }

        [HttpGet("signUp")]
        public string SignUp(string email, string password)
        {
            var user = new SignInDTO();
            user.email = email;
            user.password = password;
            try
            {
                return JsonSerializer.Serialize(_authenticationService.SignUpNew(user));
            }
            catch (Exception ex)
            {
                var ret = new SignOutDTO();
                ret.message = ex.Message;
                return JsonSerializer.Serialize(ret);
            }
        }

        //[HttpGet("signUp")]
        //public string SignUp(/*SignInDTO user*/string login, string hashedPassword)
        //{
        //    var user = new SignDTO(login, hashedPassword);

        //    try
        //    {
        //        return _authenticationService.SignIn(user) + "";
        //    }
        //    catch (Exception ex)
        //    {
        //        return ex.Message;
        //    }
        //}
    }
}



/*
// GET: api/<ValuesController>
[HttpGet]
public IEnumerable<string> Get()
{
    return new string[] { "value1", "value2" };
}

// GET api/<ValuesController>/5
[HttpGet("{id}")]
public string Get(int id)
{
    return "value";
}

// POST api/<ValuesController>
[HttpPost]
public void Post([FromBody] string value)
{
}

// PUT api/<ValuesController>/5
[HttpPut("{id}")]
public void Put(int id, [FromBody] string value)
{
}

// DELETE api/<ValuesController>/5
[HttpDelete("{id}")]
public void Delete(int id)
{
}
*/ 