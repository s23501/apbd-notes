using Kolokwium.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChangeMeController : ControllerBase
    {
        private readonly IDbService _dbService;
        public ChangeMeController(IDbService dbService)
        {
            _dbService = dbService;
        }

        //[HttpGet]
        //[HttpPost]
        //[HttpPut]
        //[HttpDelete("{Id")]
    }
}
