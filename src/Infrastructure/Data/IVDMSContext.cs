using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
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
        public DbSet<Bank> Banks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Veteran>(ConfigureVeterans);
            builder.Entity<Beneficiary>(ConfigureBeneficiaries);
            builder.Entity<Bank>(ConfigureBanks);
        }

        private void ConfigureVeterans(EntityTypeBuilder<Veteran> builder)
        {
            builder.ToTable("claims_veteran");

            builder.HasKey(x => x.vdmsno);

            builder.Property(x => x.lastName);
            builder.Property(x => x.firstName).IsRequired(false);
            builder.Property(x => x.middleName).IsRequired(false);
            builder.Property(x => x.extensionName).IsRequired(false);
            builder.Property(x => x.currentAddress1).IsRequired(false);
            builder.Property(x => x.currentAddress2).IsRequired(false);
            builder.Property(x => x.currentAddress3).IsRequired(false);
            builder.Property(x => x.currentZipCode).IsRequired(false);
            builder.Property(x => x.dateOfBirth).IsRequired(false);
            builder.Property(x => x.placeOfBirth).IsRequired(false);
            builder.Property(x => x.age).IsRequired(false);
            builder.Property(x => x.nationality).IsRequired(false);
            builder.Property(x => x.mortalStatus).IsRequired(false);
            builder.Property(x => x.causeOfDeath).IsRequired(false);
            builder.Property(x => x.placeOfDeath).IsRequired(false);
            builder.Property(x => x.sex).IsRequired(false);
            builder.Property(x => x.vfpOrganization).IsRequired(false);
            builder.Property(x => x.dateCreated).IsRequired(false);
            builder.Property(x => x.dateModified).IsRequired(false);
        }

        private void ConfigureBeneficiaries(EntityTypeBuilder<Beneficiary> builder)
        {
            builder.ToTable("claims_family");

            builder.HasKey(x => x.id);

            builder.Property(x => x.vdmsNo).IsRequired(true);
            builder.Property(x => x.lastName).IsRequired(true);
            builder.Property(x => x.firstName).IsRequired(true);
            builder.Property(x => x.middleName).IsRequired(true);
            builder.Property(x => x.extensionName).IsRequired(false);
            builder.Property(x => x.relationCode).IsRequired(false);
            builder.Property(x => x.dateOfBirth).IsRequired(false);
            builder.Property(x => x.placeOfBirth).IsRequired(false);
            builder.Property(x => x.mortalStatus).IsRequired(false);
            builder.Property(x => x.sex).IsRequired(false);
            builder.Property(x => x.mobile).IsRequired(false);
            builder.Property(x => x.telephone).IsRequired(false);
            builder.Property(x => x.dateOfDeath).IsRequired(false);
            builder.Property(x => x.placeOfDeath).IsRequired(false);
            builder.Property(x => x.currentAddress1).IsRequired(false);
            builder.Property(x => x.currentAddress2).IsRequired(false);
            builder.Property(x => x.currentAddress3).IsRequired(false);
            builder.Property(x => x.currentZipCode).IsRequired(false);
            builder.Property(x => x.emailaddress).IsRequired(false);
            builder.Property(x => x.dateCreated).IsRequired(false);
        }

        private void ConfigureBanks(EntityTypeBuilder<Bank> builder)
        {
            builder.ToTable("mdm_banks");

            builder.HasKey(x => x.id);

            builder.Property(x => x.bankCode).IsRequired(true);
            builder.Property(x => x.bankName).IsRequired(true);
            builder.Property(x => x.bankBranch).IsRequired(true);
            builder.Property(x => x.bankAddress).IsRequired(true);
            builder.Property(x => x.zipCode).IsRequired(true);
        }
    }
}
