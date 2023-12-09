using Business.Abstracts;
using Business.Dtos.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamersController : ControllerBase
    {
        IGamerService _gamerService;
        public GamersController(IGamerService gamerService)
        {
            _gamerService = gamerService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateGamerRequest createGamerRequest)
        {
            var result = await _gamerService.Add(createGamerRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _gamerService.GetAll();
            return Ok(result);
        }
    }
}
