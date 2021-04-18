using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PVAO.ApplicationCore.Entities.Structure;
using PVAO.ApplicationCore.Interfaces;

namespace PVAO.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VeteranController : ControllerBase
    {
        private readonly IVeteranService _service;

        public VeteranController(IVeteranService service)
        {
            _service = service;
        }

        [HttpGet("[action]")]
        public IEnumerable<Veteran> Get()
        {
            return _service.Get();
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            var entity = await _service.GetById(id);

            var veteran = new
            {
                vdmsno = entity.vdmsno,
                lastName = entity.lastName,
                firstName = entity.firstName,
                middleName = entity.middleName,
                extensionName = entity.extensionName,
                currentAddress1 = entity.currentAddress1,
                currentAddress2 = entity.currentAddress2,
                currentAddress3 = entity.currentAddress3,
                currentZipCode = entity.currentZipCode,
                dateOfBirth = entity.dateOfBirth,
                placeOfBirth = entity.placeOfBirth,
                age = entity.age,
                nationality = entity.nationality,
                mortalStatus = entity.mortalStatus,
                dateOfDeath = entity.dateOfDeath,
                causeOfDeath = entity.causeOfDeath,
                placeOfDeath = entity.placeOfDeath,
                sex = entity.sex,
                country = entity.country,
                vfpOrganization = entity.vfpOrganization,
                dateCreated = entity.dateCreated,
                dateModified = entity.dateModified,
            };

            return Ok(new { veteran });
        }
    }
}