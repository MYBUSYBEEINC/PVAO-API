using PVAO.ApplicationCore.Entities.Structure;
using PVAO.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PVAO.Infrastructure.Data
{
    public class ClaimChequeRepository : IVDMSRepository<ClaimCheque, int>, IClaimChequeRepository
    {
        public ClaimChequeRepository(IVDMSContext context) : base(context)
        {
        }

        public IQueryable<ClaimCheque> Get()
        {
            return _dbContext.ClaimCheques;
        }
    }
}
