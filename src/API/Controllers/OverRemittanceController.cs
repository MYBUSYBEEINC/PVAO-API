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
        private readonly IBeneficiariesService _beneficiariesService;

        public OverRemittanceController(IBenefitStatusService benefitStatusService, IVeteransService veteransService, IBeneficiariesService beneficiariesService)
        {
            _benefitStatusService = benefitStatusService;
            _veteransService = veteransService;
            _beneficiariesService = beneficiariesService;
        }

        [HttpGet("[action]")]
        public IEnumerable<BenefitStatus> GetBenefitStatuses()
        {
            return _benefitStatusService.Get();
        }

        [HttpGet("[action]")]
        public IEnumerable<Beneficiary> GetOverremittanceList()
        {
            // get beneficiaries
            return _beneficiariesService.Get();
        }
    }
}
