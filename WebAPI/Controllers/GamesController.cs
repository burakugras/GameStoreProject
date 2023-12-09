﻿using Business.Abstracts;
using Business.Dtos.Requests;
using Core.DataAccess.Paging;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        IGameService _gameService;
        public GamesController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateGameRequest createGameRequest)
        {
            var result = await _gameService.Add(createGameRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result=await _gameService.GetAll();
            return Ok(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update([FromBody] Game game)
        {
            var result= await _gameService.Update(game);
            return Ok(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete([FromBody] Game game)
        {
            var result = await _gameService.Delete(game);
            return Ok(result);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetGame(Guid id)
        {
            var result = await _gameService.Get(id);
            return Ok(result);
        }
    }
}
