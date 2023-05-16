using _2_Services.Interfaces;
using _2_Services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _1_UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleDetailsController : ControllerBase
{
        private readonly IVehicleDetailsService _vehicleDetailsService;
        public VehicleDetailsController(IVehicleDetailsService vehicleDetailsService)
        {
            _vehicleDetailsService = vehicleDetailsService;
        }


        // GET: api/<Children2Controller>
        [HttpGet]
        public async Task<IEnumerable<VehicleDetailsModel>> Get()
        {
            return await _vehicleDetailsService.GetAll();
        }

        // GET api/<Children2Controller>/5
        [HttpGet("{id}")]
        public async Task<VehicleDetailsModel> Get(int id)
        {
            return await _vehicleDetailsService.GetById(id);
        }

        // POST api/<Children2Controller>
        [HttpPost]
        public async Task<VehicleDetailsModel> Post([FromBody] VehicleDetailsModel value)
        {
            return await _vehicleDetailsService.Add(value);

        }

        // PUT api/<Children2Controller>/5
        [HttpPut("{id}")]
        public async Task<VehicleDetailsModel> Put(int id, [FromBody] VehicleDetailsModel value)
        {
            return await _vehicleDetailsService.Update(value);
        }

        // DELETE api/<Children2Controller>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _vehicleDetailsService.Delete(id);
        }
    }
}
