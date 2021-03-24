using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PVAO.ApplicationCore.Entities.Structure;
using PVAO.ApplicationCore.Interfaces;

namespace PVAO.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OverRemittanceController : Controller
    {
        private readonly IBenefitStatusService _service;

        public OverRemittanceController(IBenefitStatusService service)
        {
            _service = service;
        }

        [HttpGet("[action]")]
        public IEnumerable<BenefitStatus> GetBenefitStatuses()
        {
            return _service.Get();
        }

    }
}
