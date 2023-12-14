using Business.Abstracts;
using Business.Dtos.Requests;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampaignsController : ControllerBase
    {
        ICampaignService _campaignService;
        public CampaignsController(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateCampaignRequest createCampaignRequest)
        {
            var result = await _campaignService.Add(createCampaignRequest);
            return Ok(result);
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _campaignService.GetAll();
            return Ok(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update([FromBody] UpdateCampaignRequest updateCampaignRequest)
        {
            var result = await _campaignService.Update(updateCampaignRequest);
            return Ok(result);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromBody] Campaign campaign)
        {

            var result = await _campaignService.Delete(campaign);
            return Ok(result);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetGame(Guid id)
        {
            var result = await _campaignService.Get(id);
            return Ok(result);
        }
    }
}
