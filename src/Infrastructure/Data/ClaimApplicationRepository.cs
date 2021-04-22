using PVAO.ApplicationCore.Entities.Structure;
using PVAO.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PVAO.Infrastructure.Data
{
    public class ClaimApplicationRepository : IVDMSRepository<ClaimApplication, int>, IClaimApplicationRepository
    {
        public ClaimApplicationRepository(IVDMSContext context) : base(context)
        {
        }

        public IQueryable<ClaimApplication> Get()
        {
            return _dbContext.ClaimApplications;
        }
    }
}
