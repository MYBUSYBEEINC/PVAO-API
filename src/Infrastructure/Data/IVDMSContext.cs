using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PVAO.ApplicationCore.Entities.IVDMS;
using PVAO.ApplicationCore.Entities.Security;
using PVAO.ApplicationCore.Entities.Structure;

namespace PVAO.Infrastructure.Data
{
    public class IVDMSContext : DbContext
    {
        public IVDMSContext(DbContextOptions<IVDMSContext> options) : base(options)
        {
        }

        public DbSet<Veteran> Veterans { get; set; }
        public DbSet<Beneficiary> Beneficiaries { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Veteran>(ConfigureVeterans);
            builder.Entity<Beneficiary>(ConfigureBeneficiaries);
        }

        private void ConfigureVeterans(EntityTypeBuilder<Veteran> builder)
        {
            builder.ToTable("claims_veteran");

            builder.HasKey(x => x.VdmsNo);
            builder.Property(x => x.VdmsNo).UseIdentityColumn();

            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.MiddleName).IsRequired();
            builder.Property(x => x.LastName).IsRequired();
            builder.Property(x => x.Age).IsRequired();
            builder.Property(x => x.Sex).IsRequired();
        }

        private void ConfigureBeneficiaries(EntityTypeBuilder<Beneficiary> builder)
        {
            builder.ToTable("claims_family");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.VdmsNo).IsRequired();
            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.MiddleName).IsRequired();
            builder.Property(x => x.LastName).IsRequired();
            builder.Property(x => x.DateOfBirth).IsRequired();
            builder.Property(x => x.Sex).IsRequired();
        }
    }
}
