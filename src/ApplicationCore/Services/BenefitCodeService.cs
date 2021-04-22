using PVAO.ApplicationCore.Entities.Structure;
using PVAO.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PVAO.ApplicationCore.Services
{
    public class BenefitCodeService : IBenefitCodeService
    {
        private readonly IBenefitCodeRepository _repository;

        public BenefitCodeService(IBenefitCodeRepository repository)
        {
            _repository = repository;
        }

        public IQueryable<BenefitCode> Get()
        {
            return _repository.Get();
        }
    }
}
