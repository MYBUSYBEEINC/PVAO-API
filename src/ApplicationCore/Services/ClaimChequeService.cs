using PVAO.ApplicationCore.Entities.Structure;
using PVAO.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PVAO.ApplicationCore.Services
{
    public class ClaimChequeService : IClaimChequeService
    {
        private readonly IClaimChequeRepository _repository;

        public ClaimChequeService(IClaimChequeRepository repository)
        {
            _repository = repository;
        }

        public IQueryable<ClaimCheque> Get()
        {
            return _repository.Get();
        }
    }
}
