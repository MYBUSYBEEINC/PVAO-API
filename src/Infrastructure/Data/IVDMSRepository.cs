using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PVAO.ApplicationCore;
using PVAO.ApplicationCore.Interfaces;

namespace PVAO.Infrastructure.Data
{
    public class IVDMSRepository<EntityType, IdType> : IAsyncRepository<EntityType, IdType> where EntityType : BaseEntity<IdType>
    {
        protected readonly IVDMSContext _dbContext;

        public IVDMSRepository(IVDMSContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<EntityType>> ListAllAsync()
        {
            return await _dbContext.Set<EntityType>().ToListAsync();
        }

        public async Task<EntityType> AddAsync(EntityType entity)
        {
            _dbContext.Set<EntityType>().Add(entity);

            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<EntityType> UpdateAsync(EntityType entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;

            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task DeleteAsync(EntityType entity)
        {
            _dbContext.Set<EntityType>().Remove(entity);

            await _dbContext.SaveChangesAsync();
        }

        public async Task<EntityType> GetByIdAsync(IdType id)
        {
            return await _dbContext.Set<EntityType>().FindAsync(id);
        }
    }
}
