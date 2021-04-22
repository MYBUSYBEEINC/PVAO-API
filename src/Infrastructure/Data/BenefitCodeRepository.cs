using PVAO.ApplicationCore.Entities.Structure;
using PVAO.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PVAO.Infrastructure.Data
{
    public class BenefitCodeRepository : IVDMSRepository<BenefitCode, int>, IBenefitCodeRepository
    {
        public BenefitCodeRepository(IVDMSContext dbContext) : base(dbContext)
        {
        }

        public IQueryable<BenefitCode> Get()
        {
            return _dbContext.BenefitCodes;
        }
    }
}
