using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PVAO.ApplicationCore.Entities.Structure;
using PVAO.ApplicationCore.Interfaces;

namespace PVAO.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BeneficiaryController : ControllerBase
    {
        private readonly IBeneficiaryService _service;

        public BeneficiaryController(IBeneficiaryService service)
        {
            _service = service;
        }

        [HttpGet("[action]")]
        public IEnumerable<Beneficiary> Get()
        {
            return _service.Get();
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            var entity = await _service.GetById(id);

            var settings = new
            {
                id = entity.id,
                vdmsNo = entity.vdmsNo,
                lastName = entity.lastName,
                firstName = entity.firstName,
                middleName = entity.middleName,
                extensionName = entity.extensionName,
                relationCode = entity.relationCode,
                dateOfBirth = entity.dateOfBirth,
                placeOfBirth = entity.placeOfBirth,
                mortalStatus = entity.mortalStatus,
                sex = entity.sex,
                mobile = entity.mobile,
                telephone = entity.telephone,
                dateOfDeath = entity.dateOfDeath,
                placeOfDeath = entity.placeOfDeath,
                currentAddress1 = entity.currentAddress1,
                currentAddress2 = entity.currentAddress2,
                currentAddress3 = entity.currentAddress3,
                currentZipCode = entity.currentZipCode,
                emailaddress = entity.emailaddress,
                dateCreated = entity.dateCreated
            };

            return Ok(new { settings });
        }

        [HttpGet("[action]")]
        public IActionResult GetByVeteranId([FromQuery] string veteranId)
        {
            var entity = _service.GetByVeteranId(veteranId);

            var beneficiary = new
            {
                id = entity.id,
                vdmsNo = entity.vdmsNo,
                lastName = entity.lastName,
                firstName = entity.firstName,
                middleName = entity.middleName,
                extensionName = entity.extensionName,
                relationCode = entity.relationCode,
                dateOfBirth = entity.dateOfBirth,
                placeOfBirth = entity.placeOfBirth,
                mortalStatus = entity.mortalStatus,
                sex = entity.sex,
                mobile = entity.mobile,
                telephone = entity.telephone,
                dateOfDeath = entity.dateOfDeath,
                placeOfDeath = entity.placeOfDeath,
                currentAddress1 = entity.currentAddress1,
                currentAddress2 = entity.currentAddress2,
                currentAddress3 = entity.currentAddress3,
                currentZipCode = entity.currentZipCode,
                emailaddress = entity.emailaddress,
                dateCreated = entity.dateCreated
            };

            return Ok(new { beneficiary });
        }
    }
}