using _2_Services.Interfaces;
using _2_Services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _1_UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
{
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        // GET: api/<Children2Controller>
        [HttpGet]
        public async Task<IEnumerable<UserModel>> Get()
        {
            return await _userService.GetAll();
        }

        // GET api/<Children2Controller>/5
        [HttpGet("{id}")]
        public async Task<UserModel> Get(int id)
        {
            return await _userService.GetById(id);
        }

        // POST api/<Children2Controller>
        [HttpPost]
        public async Task<UserModel> Post([FromBody] UserModel value)
        {
            return await _userService.Add(value);

        }

        // PUT api/<Children2Controller>/5
        [HttpPut("{id}")]
        public async Task<UserModel> Put(int id, [FromBody] UserModel value)
        {
            return await _userService.Update(value);
        }

        // DELETE api/<Children2Controller>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _userService.Delete(id);
        }
    }
}
