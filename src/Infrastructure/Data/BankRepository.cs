using PVAO.ApplicationCore.Entities.Structure;
using PVAO.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVAO.Infrastructure.Data
{
    public class BankRepository : IVDMSRepository<Bank, int>, IBankRepository
    {
        public BankRepository(IVDMSContext context) : base(context)
        {
        }

        public IQueryable<Bank> Get()
        {
            return _dbContext.Banks;
        }

        public async Task<Bank> GetById(int id)
        {
            return await GetByIdAsync(id);
        }
    }
}
