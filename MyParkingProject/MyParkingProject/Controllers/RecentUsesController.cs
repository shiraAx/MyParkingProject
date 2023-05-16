using _2_Services.Interfaces;
using _2_Services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _1_UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecentUsesController : ControllerBase
{
        private readonly IRecentUsesService _recentUsesService;
        public RecentUsesController(IRecentUsesService recentUsesService)
        {
            _recentUsesService = recentUsesService;
        }


        // GET: api/<Children2Controller>
        [HttpGet]
        public async Task<IEnumerable<RecentUsesModel>> Get()
        {
            return await _recentUsesService.GetAll();
        }

        // GET api/<Children2Controller>/5
        [HttpGet("{id}")]
        public async Task<RecentUsesModel> Get(int id)
        {
            return await _recentUsesService.GetById(id);
        }

        // POST api/<Children2Controller>
        [HttpPost]
        public async Task<RecentUsesModel> Post([FromBody] RecentUsesModel value)
        {
            return await _recentUsesService.Add(value);

        }

        // PUT api/<Children2Controller>/5
        [HttpPut("{id}")]
        public async Task<RecentUsesModel> Put(int id, [FromBody] RecentUsesModel value)
        {
            return await _recentUsesService.Update(value);
        }

        // DELETE api/<Children2Controller>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _recentUsesService.Delete(id);
        }
    }
}
