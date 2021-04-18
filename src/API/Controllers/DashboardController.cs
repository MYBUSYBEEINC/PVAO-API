using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PVAO.ApplicationCore.Entities.IVDMS;
using PVAO.ApplicationCore.Interfaces;

namespace PVAO.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DashboardController : ControllerBase
    {
        private readonly IVeteransService _veteransService;

        public DashboardController(IVeteransService veteransService)
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
