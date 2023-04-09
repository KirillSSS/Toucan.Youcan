using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Toucan.Youcan.DTOs;
using Toucan.Youcan.Services;
using Toucan.Youcan.Services.Abstractions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Toucan.Youcan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpGet("signin/{login}/{hashedPassword}")]
        public string SignIn(/*SignInDTO user*/string login, string hashedPassword)
        {
            var user = new SignDTO(login, hashedPassword);

            try
            {
                return _authenticationService.SignIn(user) + "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        [HttpGet("signin/{login}/{hashedPassword}")]
        public string SignUp(/*SignInDTO user*/string login, string hashedPassword)
        {
            var user = new SignDTO(login, hashedPassword);

            try
            {
                return _authenticationService.SignIn(user) + "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
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