using Microsoft.AspNetCore.Mvc;
using MSR_APIS.Helper;
//using Newtonsoft.Json;
using System.Text.Json;
using MSR_APIS.Models;

namespace MSR_APIS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommonController : Controller
    {

        private readonly ApiHelper _apiHelper;

        public CommonController(ApiHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

        [HttpPost("GetMSRBanner")]
        public async Task<IActionResult> GetMSRBanner([FromBody]GetCity request)
        {
            var response = await _apiHelper.GetMSRBannerAsync(request.CityName);

            if (response.IsSuccess)
            {
                return Content(JsonSerializer.Serialize(response.Data), "application/json");

            }
            else
            {
                return StatusCode(response.StatusCode, new
                {
                    response.IsSuccess,
                    response.Message,
                    response.Error
                });
            }
        }

        [HttpPost("GetTierDetailsById")]
        public async Task<IActionResult> GetTierDetailsById([FromBody] TierRequest request)
        {

            var response = await _apiHelper.GetTierDetailsByIdAsync(request);

            if (response.IsSuccess)
            {
                return Content(JsonSerializer.Serialize(response.Data), "application/json");

            }
            else
            {
                return StatusCode(response.StatusCode, new
                {
                    response.IsSuccess,
                    response.Message,
                    response.Error
                });
            }
        }

        [HttpPost("GetMSRPopUp")]
        public async Task<IActionResult> GetMSRPopUp([FromBody] GetCity request)
        {
            var response = await _apiHelper.GetMSRPopUpAsync(request.CityName);

            if (response.IsSuccess)
            {
                return Content(JsonSerializer.Serialize(response.Data), "application/json");

            }
            else
            {
                return StatusCode(response.StatusCode, new
                {
                    response.IsSuccess,
                    response.Message,
                    response.Error
                });
            }
        }

        [HttpPost("SendMSREmail")]
        public async Task<IActionResult> SendMSREmail([FromBody] EmailTemplate request)
        {
            var response = await _apiHelper.SendMSREmailAsync(request);

            if (response.IsSuccess)
            {
                return Content(JsonSerializer.Serialize(response.Data), "application/json");

            }
            else
            {
                return StatusCode(response.StatusCode, new
                {
                    response.IsSuccess,
                    response.Message,
                    response.Error
                });
            }
        }

        [HttpGet("GetAPIForSupport")]
        public async Task<IActionResult> GetAPIForSupport()
        {
            var response = await _apiHelper.GetAPIForSupportAsync();

            if (response.IsSuccess)
            {
                return Content(response.Data,"application/json");
            }
            else
            {
                return StatusCode(response.StatusCode, new
                {
                    response.IsSuccess,
                    response.Message,
                    response.Error
                });
            }
        }
    }
    
}
    
