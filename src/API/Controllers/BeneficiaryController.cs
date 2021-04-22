using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PVAO.ApplicationCore.Entities.Structure;
using PVAO.ApplicationCore.Helpers;
using PVAO.ApplicationCore.Interfaces;

namespace PVAO.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BeneficiaryController : ControllerBase
    {
        private readonly IClaimApplicationService _claimApplicationService;
        private readonly IClaimChequeService _claimChequeService;
        private readonly IBeneficiaryService _beneficiaryService;
        private readonly IVeteranService _veteranService;
        private readonly IBenefitCodeService _benefitCodeService;

        public BeneficiaryController(IClaimApplicationService claimApplicationService, IClaimChequeService claimChequeService, IBeneficiaryService beneficiaryService,
            IVeteranService veteranService, IBenefitCodeService benefitCodeService)
        {
            _claimApplicationService = claimApplicationService;
            _claimChequeService = claimChequeService;
            _beneficiaryService = beneficiaryService;
            _veteranService = veteranService;
            _benefitCodeService = benefitCodeService;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetOverRemittances([FromQuery] int currentPage, [FromQuery] int pageSize)
        {
            IQueryable<ClaimApplication> result = _claimApplicationService.Get();

            var paginatedList = await PaginatedList<ClaimApplication>.CreateAsync(result, currentPage, pageSize);

            List<object> overRemittances = new List<object>();

            foreach (var item in paginatedList)
            {
                var veteran = await _veteranService.GetById(int.Parse(item.vdmsNo));

                if (veteran.mortalStatus == "DECEASED")
                {
                    double claimCheque = (double)_claimChequeService.Get().Where(x => x.claimNo == item.claimNo && x.dateCreated >= veteran.dateOfDeath).Sum(x => x.checkAmount);

                    var beneficiary = _beneficiaryService.Get().Where(x => x.lastName.Equals(item.lastName) && x.firstName.Equals(item.firstName) && x.middleName.Equals(item.middleName)).FirstOrDefault();

                    var data = new
                    {
                        claimNumber = item.claimNo,
                        benefitCode = _benefitCodeService.Get().FirstOrDefault(x => x.benefitCode == item.benefitCode).benefit,
                        vdmsNumber = item.vdmsNo,
                        beneficiaryName = string.Format("{0}, {1} {2}", item.lastName, item.firstName, item.middleName),
                        relation = beneficiary.relationCode,
                        gender = beneficiary.sex,
                        amount = Convert.ToDecimal(claimCheque).ToString("#,##0.00"),
                        status = "For Computation"
                    };

                    overRemittances.Add(data);
                }
            }

            return Ok(new { overRemittances, totalItems = overRemittances.Count(), paginatedList.PageCount, paginatedList.PageSize });
        }

        [HttpGet("[action]")]
        public IActionResult GetOverRemittanceById([FromQuery] string claimNumber)
        {
            var entity = _claimApplicationService.Get().Where(x => x.claimNo == claimNumber).FirstOrDefault();

            int vdmsNumber = int.Parse(entity.vdmsNo);

            var veteran = _veteranService.Get().Where(x => x.vdmsno == vdmsNumber).FirstOrDefault();

            var beneficiary = _beneficiaryService.Get().Where(x => x.lastName.Equals(entity.lastName) && x.firstName.Equals(entity.firstName) && x.middleName.Equals(entity.middleName)).FirstOrDefault();

            var overRemittance = new
            {
                claimNumber = entity.claimNo,
                vdmsNumber = entity.vdmsNo,
                lastName = entity.lastName,
                firstName = entity.firstName,
                middleName = entity.middleName,
                status = "For Computation",
                beneficiaryName = string.Format("{0}, {1} {2}", beneficiary.lastName, beneficiary.firstName, beneficiary.middleName),
                relation = beneficiary.relationCode,
                address = string.Format("{0} {1} {2}", beneficiary.currentAddress1, beneficiary.currentAddress2, beneficiary.currentAddress3),
                mobileNumber = beneficiary.mobile,
                emailAddress = beneficiary.emailaddress,
                veteranName = string.Format("{0}, {1} {2}", veteran.lastName, veteran.firstName, veteran.middleName),
                nationality = veteran.nationality,
                organization = veteran.vfpOrganization,
                dateOfBirth = veteran.dateOfBirth,
                age = veteran.age,
                gender = veteran.sex,
                dateOfDeath = veteran.dateOfDeath,
                causeOfDeath = veteran.causeOfDeath
            };

            return Ok(new { overRemittance });
        }
    }
}