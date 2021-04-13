using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PVAO.ApplicationCore.Entities.IVDMS;
using PVAO.ApplicationCore.Entities.Structure;
using PVAO.ApplicationCore.Interfaces;

namespace PVAO.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OverRemittanceController : Controller
    {
        private readonly IBenefitStatusService _benefitStatusService;
        private readonly IVeteransService _veteransService;

        public OverRemittanceController(IBenefitStatusService benefitStatusService, IVeteransService veteransService)
        {
            _benefitStatusService = benefitStatusService;
            _veteransService = veteransService;
        }

        [HttpGet("[action]")]
        public IEnumerable<BenefitStatus> GetBenefitStatuses()
        {
            return _benefitStatusService.Get();
        }

        [HttpGet("[action]")]
        public IEnumerable<Veteran> GetOverremittanceList()
        {
            return _veteransService.Get();
        }
    }
}
