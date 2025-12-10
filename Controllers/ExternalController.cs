using Microsoft.AspNetCore.Mvc;
using MiPrimerAPI.Services;
using MiPrimerAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiPrimerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExternalController : ControllerBase
    {
        private readonly ExternalApiService _apiService;

        public ExternalController(ExternalApiService apiService)
        {
            _apiService = apiService;
        }

        [HttpGet("users")]
        public async Task<ActionResult<List<User>>> GetUsers()
        {
            var result = await _apiService.GetUsersAsync();
            return Ok(result);
        }
    }
}


