using PVAO.ApplicationCore.Entities.Structure;
using PVAO.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PVAO.ApplicationCore.Services
{
    public class ClaimApplicationService : IClaimApplicationService
    {
        private readonly IClaimApplicationRepository _repository;

        public ClaimApplicationService(IClaimApplicationRepository repository)
        {
            _repository = repository;
        }

        public IQueryable<ClaimApplication> Get()
        {
            return _repository.Get();
        }
    }
}
