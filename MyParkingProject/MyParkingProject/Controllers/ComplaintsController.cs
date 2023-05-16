using _2_Services.Interfaces;
using _2_Services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _1_UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComplaintsController : ControllerBase
{
        private readonly IComplaintsService _complaintsService;
        public ComplaintsController(IComplaintsService complaintsService)
        {
            _complaintsService = complaintsService;
        }


        // GET: api/<Children2Controller>
        [HttpGet]
        public async Task<IEnumerable<ComplaintsModel>> Get()
        {
            return await _complaintsService.GetAll();
        }

        // GET api/<Children2Controller>/5
        [HttpGet("{id}")]
        public async Task<ComplaintsModel> Get(int id)
        {
            return await _complaintsService.GetById(id);
        }

        // POST api/<Children2Controller>
        [HttpPost]
        public async Task<ComplaintsModel> Post([FromBody] ComplaintsModel value)
        {
            return await _complaintsService.Add(value);

        }

        // PUT api/<Children2Controller>/5
        [HttpPut("{id}")]
        public async Task<ComplaintsModel> Put(int id, [FromBody] ComplaintsModel value)
        {
            return await _complaintsService.Update(value);
        }

        // DELETE api/<Children2Controller>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _complaintsService.Delete(id);
        }
    }
}
