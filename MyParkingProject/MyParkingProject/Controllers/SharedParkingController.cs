using _2_Services.Interfaces;
using _2_Services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _1_UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SharedParkingController : ControllerBase
{
        private readonly ISharedParkingService _SharedParkingService;
        public SharedParkingController(ISharedParkingService SharedParkingService)
        {
            _SharedParkingService = SharedParkingService;
        }


        // GET: api/<Children2Controller>
        [HttpGet]
        public async Task<IEnumerable<SharedParkingModel>> Get()
        {
            return await _SharedParkingService.GetAll();
        }

        // GET api/<Children2Controller>/5
        [HttpGet("{id}")]
        public async Task<SharedParkingModel> Get(int id)
        {
            return await _SharedParkingService.GetById(id);
        }

        // POST api/<Children2Controller>
        [HttpPost]
        public async Task<SharedParkingModel> Post([FromBody] SharedParkingModel value)
        {
            return await _SharedParkingService.Add(value);

        }

        // PUT api/<Children2Controller>/5
        [HttpPut("{id}")]
        public async Task<SharedParkingModel> Put(int id, [FromBody] SharedParkingModel value)
        {
            return await _SharedParkingService.Update(value);
        }

        // DELETE api/<Children2Controller>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _SharedParkingService.Delete(id);
        }
    }
}
