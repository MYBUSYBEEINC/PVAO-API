using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PVAO.ApplicationCore.Entities.Structure;
using PVAO.ApplicationCore.Interfaces;

namespace PVAO.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DashboardController : ControllerBase
    {
        private readonly IVeteranService _veteranService;
        private readonly IBeneficiaryService _beneficiaryService;

        public DashboardController(IVeteranService veteranService, IBeneficiaryService beneficiaryService)
        {
            _veteranService = veteranService;
            _beneficiaryService = beneficiaryService;
        }

        [HttpGet("[action]")]
        public IEnumerable<Veteran> Get()
        {
            return _veteranService.Get();
        }

        [HttpGet("[action]")]
        public int GetTotalVeterans()
        {
            return _veteranService.Get().Count();
        }


        [HttpGet("[action]")]
        public int GetTotalBeneficiaries()
        {
            return _beneficiaryService.Get().Count();
        }
    }
}
