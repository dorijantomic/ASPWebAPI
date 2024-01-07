using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShirtsController: ControllerBase
    {
        [HttpGet]
        public string GetShirts()
        {
            return "Reading all the shirts";
        }
        [HttpGet("{id}")]
        public string GetShirtsById(int id)
        {
            return $"Reading shirt: {id}";
        }
        [HttpPost]
        public string CreateShirt([FromBody]ShirtModel shirt)
        {
            return "Creating a shirt";
        }
        [HttpPut("{id}")]
        public string UpdateShirt(int id)
        {
            return $"Updating shirt: {id}";
        }
        [HttpDelete("{id}")]
        public string DeleteShirt(int id) {
            return $"Deleting shirt: {id}";
        }
    }
}
