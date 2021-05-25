using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
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
        private readonly IBenefitStatusService _benefitStatusService;

        public BeneficiaryController(IClaimApplicationService claimApplicationService, IClaimChequeService claimChequeService, IBeneficiaryService beneficiaryService,
            IVeteranService veteranService, IBenefitCodeService benefitCodeService, IBenefitStatusService benefitStatusService)
        {
            _claimApplicationService = claimApplicationService;
            _claimChequeService = claimChequeService;
            _beneficiaryService = beneficiaryService;
            _veteranService = veteranService;
            _benefitCodeService = benefitCodeService;
            _benefitStatusService = benefitStatusService;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetOverRemittances([FromQuery] string searchValue = "", [FromQuery] int? year = null, [FromQuery] string month = "", [FromQuery] int currentPage = 1, [FromQuery] int pageSize = 10)
        {
            IQueryable<ClaimApplication> result = _claimApplicationService.Get();

            if (!string.IsNullOrEmpty(searchValue))
            {
                result = result.Where(x => x.claimNo.ToLower().Contains(searchValue.ToLower()) || x.vdmsNo.ToLower().Contains(searchValue.ToLower()) || x.lastName.ToLower().Contains(searchValue.ToLower()) ||
                    x.firstName.ToLower().Contains(searchValue.ToLower()) || x.middleName.ToLower().Contains(searchValue.ToLower()) || x.benefitCode.ToLower().Contains(searchValue.ToLower()));
            }

            if (year != null)
                result = result.Where(x => x.dateApproved.Value.Year == year);

            if (!string.IsNullOrEmpty(month))
            {
                int monthInteger = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month;

                result = result.Where(x => x.dateApproved.Value.Year == year && x.dateApproved.Value.Month == monthInteger);
            }
                
            var paginatedList = await PaginatedList<ClaimApplication>.CreateAsync(result, currentPage, pageSize);

            List<OverRemittance> overRemittances = new List<OverRemittance>();

            foreach (var item in paginatedList)
            {
                var veteran = await _veteranService.GetById(int.Parse(item.vdmsNo));

                if (veteran.mortalStatus == "DECEASED")
                {
                    double claimCheque = (double)_claimChequeService.Get().Where(x => x.claimNo == item.claimNo && x.dateCreated >= veteran.dateOfDeath).Sum(x => x.checkAmount);

                    var beneficiary = _beneficiaryService.Get().Where(x => x.lastName.Equals(item.lastName) && x.firstName.Equals(item.firstName) && x.middleName.Equals(item.middleName)).FirstOrDefault();

                    overRemittances.Add(new OverRemittance()
                    {
                        ClaimNumber = item.claimNo,
                        BenefitCode = _benefitCodeService.Get().FirstOrDefault(x => x.benefitCode == item.benefitCode).benefit,
                        VdmsNumber = item.vdmsNo,
                        BeneficiaryName = string.Format("{0}, {1} {2}", item.lastName, item.firstName, item.middleName),
                        Relation = beneficiary.relationCode,
                        Gender = beneficiary.sex,
                        Amount = Convert.ToDecimal(claimCheque).ToString("#,##0.00"),
                        Status = "For Computation",
                        DateApproved = item.dateApproved
                    });
                }
            }

            return Ok(new { overRemittances, totalItems = result.Count(), paginatedList.PageCount, paginatedList.PageSize });
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

        [HttpGet("[action]")]
        public IEnumerable<BenefitStatus> GetBenefitStatus()
        {
            return _benefitStatusService.Get();
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetYearsAndMonthsAsync()
        {
            IQueryable<ClaimApplication> result = _claimApplicationService.Get();

            var paginatedList = await PaginatedList<ClaimApplication>.CreateAsync(result, 1, 1000000000);

            List<OverRemittance> overRemittances = new List<OverRemittance>();

            foreach (var item in paginatedList)
            {
                var veteran = await _veteranService.GetById(int.Parse(item.vdmsNo));

                if (veteran.mortalStatus == "DECEASED")
                {
                    double claimCheque = (double)_claimChequeService.Get().Where(x => x.claimNo == item.claimNo && x.dateCreated >= veteran.dateOfDeath).Sum(x => x.checkAmount);

                    var beneficiary = _beneficiaryService.Get().Where(x => x.lastName.Equals(item.lastName) && x.firstName.Equals(item.firstName) && x.middleName.Equals(item.middleName)).FirstOrDefault();

                    overRemittances.Add(new OverRemittance()
                    {
                        ClaimNumber = item.claimNo,
                        BenefitCode = _benefitCodeService.Get().FirstOrDefault(x => x.benefitCode == item.benefitCode).benefit,
                        VdmsNumber = item.vdmsNo,
                        BeneficiaryName = string.Format("{0}, {1} {2}", item.lastName, item.firstName, item.middleName),
                        Relation = beneficiary.relationCode,
                        Gender = beneficiary.sex,
                        Amount = Convert.ToDecimal(claimCheque).ToString("#,##0.00"),
                        Status = "For Computation",
                        DateApproved = item.dateApproved
                    });
                }
            }

            var years = overRemittances.GroupBy(x => x.DateApproved.Value.Year).Select(s => s.Key).ToList();

            var months = overRemittances.Select(s => s.DateApproved.Value.ToShortDateString()).ToList();

            return Ok(new { years, months });
        }

        #region Private Methods

        private async Task<int> GetTotalOverremittanceCount(List<OverRemittance> overRemittances, IQueryable<ClaimApplication> claimApplications)
        {
            int totalCount = 0;
            foreach (ClaimApplication item in claimApplications.ToList())
            {
                var veteran =  await _veteranService.GetById(int.Parse(item.vdmsNo));
                if (veteran == null) throw new ApplicationException($"Veteran with Id {item.vdmsNo} not found!");
                if (veteran.mortalStatus == "DECEASED") totalCount++;
            }

            return totalCount;
        }

        #endregion
    }
}