using _2_Services.Interfaces;
using _2_Services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _1_UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchasePointsController : ControllerBase
{
        private readonly IPurchasePointsService _purchasePointsService;
        public PurchasePointsController(IPurchasePointsService purchasePointsService)
        {
            _purchasePointsService = purchasePointsService;
        }


        // GET: api/<Children2Controller>
        [HttpGet]
        public async Task<IEnumerable<PurchasePointsModel>> Get()
        {
            return await _purchasePointsService.GetAll();
        }

        // GET api/<Children2Controller>/5
        [HttpGet("{id}")]
        public async Task<PurchasePointsModel> Get(int id)
        {
            return await _purchasePointsService.GetById(id);
        }

        // POST api/<Children2Controller>
        [HttpPost]
        public async Task<PurchasePointsModel> Post([FromBody] PurchasePointsModel value)
        {
            return await _purchasePointsService.Add(value);

        }

        // PUT api/<Children2Controller>/5
        [HttpPut("{id}")]
        public async Task<PurchasePointsModel> Put(int id, [FromBody] PurchasePointsModel value)
        {
            return await _purchasePointsService.Update(value);
        }

        // DELETE api/<Children2Controller>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _purchasePointsService.Delete(id);
        }
    }
}
