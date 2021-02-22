using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PVAO.ApplicationCore.Interfaces;

namespace PVAO.Controllers
{
    [ApiController]
    [Route("[controller]")] 
    public class AuthController : ControllerBase
    {
        private readonly TokenOptions _tokenOptions;
        private readonly ILogger<AuthController> _logger;
        private readonly ISettingsService _settingsService;

        public AuthController(IOptions<TokenOptions> tokenOptions, ILogger<AuthController> logger, ISettingsService settingsService)
        {
            _tokenOptions = tokenOptions.Value;
            _logger = logger;
            _settingsService = settingsService;
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login()
        {
            return Ok();
        }
    }
}