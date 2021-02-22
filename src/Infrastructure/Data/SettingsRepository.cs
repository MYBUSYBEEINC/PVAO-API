using PVAO.ApplicationCore.Entities.Structure;
using PVAO.ApplicationCore.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace PVAO.Infrastructure.Data
{
    public class SettingsRepository : EFRepository<Settings, int>, ISettingsRepository
    {
        public SettingsRepository(PVAOContext context) : base(context)
        {
        }

        public IQueryable<Settings> Get()
        {
            return _dbContext.Settings;
        }

        public async Task<Settings> GetById(int id)
        {
            return await GetByIdAsync(id);
        }

        public async Task<Settings> Add(Settings settings)
        {
            return await AddAsync(settings);
        }

        public async Task<Settings> Update(Settings settings)
        {
            return await UpdateAsync(settings);
        }
    }
}
