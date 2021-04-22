using PVAO.ApplicationCore.Entities.Structure;
using PVAO.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PVAO.Infrastructure.Data
{
    public class ChequeRepository : FMISRepository<Cheque, int>, IChequeRepository
    {
        public ChequeRepository(FMISContext context) : base(context)
        {
        }

        public IQueryable<Cheque> Get()
        {
            return _dbContext.Cheques;
        }
    }
}
