using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PVAO.ApplicationCore.Entities.Structure;
using PVAO.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PVAO.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SettingsController : ControllerBase
    {
        private readonly ISettingsService _service;

        public SettingsController(ISettingsService service)
        {
            _service = service;
        }

        [HttpGet("[action]")]
        public IEnumerable<Settings> Get()
        {
            return _service.Get();
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            var entity = await _service.GetById(id);

            var settings = new
            {
                id = entity.Id,
                fromEmail = entity.FromEmail,
                fromName = entity.FromName,
                serverName = entity.ServerName,
                smtpPort = entity.SMTPPort,
                username = entity.Username,
                password = entity.Password,
                enableSSL = entity.EnableSSL,
                maxSignOnAttempts = entity.MaxSignOnAttempts,
                expiresIn = entity.ExpiresIn,
                minPasswordLength = entity.MinPasswordLength,
                minSpecialCharacters = entity.MinSpecialCharacters,
                enforcePasswordHistory = entity.EnforcePasswordHistory,
                activationLinkExpiresIn = entity.ActivationLinkExpiresIn
            };

            return Ok(new { settings });
        }
    }
}