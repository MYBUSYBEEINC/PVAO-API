using System;
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
        private readonly IClaimApplicationService _claimApplicationService;

        public DashboardController(IVeteranService veteranService, IBeneficiaryService beneficiaryService, IClaimApplicationService claimApplicationService)
        {
            _veteranService = veteranService;
            _beneficiaryService = beneficiaryService;
            _claimApplicationService = claimApplicationService;
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

        [HttpGet("[action]")]
        public int GetTotalOverremittances()
        {
            IQueryable<ClaimApplication> claimApplications = _claimApplicationService.Get();
            List<Veteran> veterans = _veteranService.Get().ToList();
            int totalCount = 0;
            foreach (ClaimApplication item in claimApplications.ToList())
            {
                var veteran = veterans.FirstOrDefault(x => x.vdmsno.ToString() == item.vdmsNo);
                if (veteran == null) throw new ApplicationException($"Veteran with Id {item.vdmsNo} not found!");
                if (veteran.mortalStatus == "DECEASED") totalCount++;
            }

            return totalCount;
        }
    }
}
