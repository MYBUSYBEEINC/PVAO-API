using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PVAO.ApplicationCore.Entities.Security;

namespace PVAO.Infrastructure.Data
{
    public class IVDMSContext : DbContext
    {
        public IVDMSContext(DbContextOptions<IVDMSContext> options) : base(options)
        {
        }
    }
}
