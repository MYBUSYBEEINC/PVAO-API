using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PVAO.ApplicationCore.Entities;
using PVAO.ApplicationCore.Entities.Structure;
using PVAO.ApplicationCore.Interfaces;

namespace PVAO.Infrastructure.Data
{
    public class VeteranRepository : IVDMSRepository<Veteran, int>, IVeteranRepository

    {
        public VeteranRepository(IVDMSContext dbContext) : base(dbContext)
        {
        }

        public IQueryable<Veteran> Get()
        {
            return _dbContext.Veterans;
        }

        public async Task<Veteran> GetById(int id)
        {
            return await GetByIdAsync(id);
        }

        public async Task<Veteran> Add(Veteran veteran)
        {
            return await AddAsync(veteran);
        }

        public async Task<Veteran> Update(Veteran veteran)
        {
            return await UpdateAsync(veteran);
        }
    }
}
