using System.Linq;
using System.Threading.Tasks;
using PVAO.ApplicationCore.Entities.Structure;
using PVAO.ApplicationCore.Interfaces;

namespace PVAO.Infrastructure.Data
{
    public class BenefitStatusRepository : EFRepository<BenefitStatus, int>, IBenefitStatusRepository
    {
        public BenefitStatusRepository(PVAOContext dbContext) : base(dbContext)
        {
        }

        public IQueryable<BenefitStatus> Get()
        {
            return _dbContext.BenefitStatuses;
        }

        public async Task<BenefitStatus> GetById(int id)
        {
            return await GetByIdAsync(id);
        }

        public async Task<BenefitStatus> Add(BenefitStatus benefitStatus)
        {
            return await AddAsync(benefitStatus);
        }

        public async Task<BenefitStatus> Update(BenefitStatus benefitStatus)
        {
            return await UpdateAsync(benefitStatus);
        }
    }
}
