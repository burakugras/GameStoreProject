using Business.Abstracts;
using Business.Dtos.Requests;
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

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCampaignRequest createCampaignRequest)
        {
            var result = await _campaignService.Add(createCampaignRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _campaignService.GetAll();
            return Ok(result);
        }
    }
}
