using PVAO.ApplicationCore.Entities.Structure;
using PVAO.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PVAO.ApplicationCore.Services
{
    public class ChequeService  : IChequeService
    {
        private readonly IChequeRepository _repository;

        public ChequeService(IChequeRepository repository)
        {
            _repository = repository;
        }

        public IQueryable<Cheque> Get()
        {
            return _repository.Get();
        }
    }
}
