using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PVAO.ApplicationCore.Entities.Structure;
using PVAO.ApplicationCore.Interfaces;

namespace PVAO.Infrastructure.Data
{
    public class BeneficiaryRepository : IVDMSRepository<Beneficiary, int>, IBeneficiaryRepository
    {
        public BeneficiaryRepository(IVDMSContext dbContext) : base(dbContext)
        {
        }

        public IQueryable<Beneficiary> Get()
        {
            return _dbContext.Beneficiaries;
        }

        public async Task<Beneficiary> GetById(int id)
        {
            return await GetByIdAsync(id);
        }

        public IQueryable<Beneficiary> GetOverRemittances()
        {
            return _dbContext.Beneficiaries;
        }

        public async Task<Beneficiary> Add(Beneficiary beneficiary)
        {
            return await AddAsync(beneficiary);
        }

        public async Task<Beneficiary> Update(Beneficiary beneficiary)
        {
            return await UpdateAsync(beneficiary);
        }
    }
}
