using Business.Abstracts;
using Business.Dtos.Requests;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GamersController : ControllerBase
{
    IGamerService _gamerService;
    public GamersController(IGamerService gamerService)
    {
        _gamerService = gamerService;
    }

    [HttpPost("add")]
    public async Task<IActionResult> Add([FromBody] CreateGamerRequest createGamerRequest)
    {
        var result = await _gamerService.Add(createGamerRequest);
        return Ok(result);
    }

    [HttpGet("getall")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _gamerService.GetAll();
        return Ok(result);
    }

    [HttpPost("update")]
    public async Task<IActionResult> Update([FromBody] UpdateGamerRequest updateGamerRequest)
    {
        var result = await _gamerService.Update(updateGamerRequest);
        return Ok(result);
    }

    [HttpDelete("delete")]
    public async Task<IActionResult> Delete([FromBody] Gamer gamer)
    {
        var result = await _gamerService.Delete(gamer);
        return Ok(result);
    }

    [HttpGet("getbyid")]
    public async Task<IActionResult> GetGamer(Guid id)
    {
        var result = await _gamerService.Get(id);
        return Ok(result);
    }
}
