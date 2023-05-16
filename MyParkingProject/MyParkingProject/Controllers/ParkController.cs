using _2_Services.Interfaces;
using _2_Services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _1_UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkController : ControllerBase
{
        private readonly IParkService _ParkService;
        public ParkController(IParkService ParkService)
        {
            _ParkService = ParkService;
        }


        // GET: api/<Children2Controller>
        [HttpGet]
        public async Task<IEnumerable<ParkModel>> Get()
        {
            return await _ParkService.GetAll();
        }

        // GET api/<Children2Controller>/5
        [HttpGet("{id}")]
        public async Task<ParkModel> Get(int id)
        {
            return await _ParkService.GetById(id);
        }

        // POST api/<Children2Controller>
        [HttpPost]
        public async Task<ParkModel> Post([FromBody] ParkModel value)
        {
            return await _ParkService.Add(value);

        }

        // PUT api/<Children2Controller>/5
        [HttpPut("{id}")]
        public async Task<ParkModel> Put(int id, [FromBody] ParkModel value)
        {
            return await _ParkService.Update(value);
        }

        // DELETE api/<Children2Controller>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _ParkService.Delete(id);
        }
    }
}
