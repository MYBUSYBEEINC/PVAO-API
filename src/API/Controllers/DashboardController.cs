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
        private readonly IVeteranService _veteransService;

        public DashboardController(IVeteranService veteransService)
        {
            _veteransService = veteransService;
        }

        [HttpGet("[action]")]
        public IEnumerable<Veteran> Get()
        {
            return _veteransService.Get();
        }

        [HttpGet("[action]")]
        public int GetVeteransCount()
        {
            return _veteransService.Get().Count();
        }
    }
}
