using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Toucan.Youcan.Services;
using Toucan.Youcan.Services.Abstractions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Toucan.Youcan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserLoginController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserLoginController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("testdays/{startDate}/{frequency}/{start}/{end}")]
        public string Test(string startDate, int frequency, string start, string end)
        {
            DateTime.TryParse(startDate, out var sD);
            DateTime.TryParse(start, out var s);
            DateTime.TryParse(end, out var e);

            return _userService.testDays(sD, frequency, s, e);
        }

        [HttpGet("testweeks/{startDate}/{frequency}/{start}/{end}/{days}")]
        public string TestWeeks(string startDate, int frequency, string start, string end, string days)
        {
            DateTime.TryParse(startDate, out var sD);
            DateTime.TryParse(start, out var s);
            DateTime.TryParse(end, out var e);

            return _userService.testWeeks(sD, frequency, s, e, days.Split(',').Select(day => Enum.Parse<DayOfWeek>(day)).ToHashSet());
        }

        [HttpGet("getdate/{days}")]
        public string GetDate(int days)
        {
            return _userService.GetDate(days);
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