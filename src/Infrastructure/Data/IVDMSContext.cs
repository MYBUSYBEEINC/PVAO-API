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

        public DbSet<ClaimApplication> ClaimApplications { get; set; }
        public DbSet<ClaimCheque> ClaimCheques { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Veteran> Veterans { get; set; }
        public DbSet<Beneficiary> Beneficiaries { get; set; }
        public DbSet<BenefitCode> BenefitCodes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ClaimApplication>(ConfigureClaimApplication);
            builder.Entity<ClaimCheque>(ConfigureCheque);
            builder.Entity<Veteran>(ConfigureVeterans);
            builder.Entity<Beneficiary>(ConfigureBeneficiaries);
            builder.Entity<Bank>(ConfigureBanks);
            builder.Entity<BenefitCode>(ConfigureBenefitCodes);
        }

        private void ConfigureClaimApplication(EntityTypeBuilder<ClaimApplication> builder)
        {
            builder.ToTable("claims_applications");

            builder.HasKey(x => x.claimNo);

            builder.Property(x => x.vdmsNo).IsRequired(true);
            builder.Property(x => x.benefitCode).IsRequired(false);
            builder.Property(x => x.middleName).IsRequired(false);
            builder.Property(x => x.lastName).IsRequired(false);
            builder.Property(x => x.firstName).IsRequired(false);
            builder.Property(x => x.middleName).IsRequired(false);
            builder.Property(x => x.referenceNumber).IsRequired(false);
            builder.Property(x => x.dateFiled).IsRequired(false);
            builder.Property(x => x.dateApproved).IsRequired(false);
        }

        private void ConfigureCheque(EntityTypeBuilder<ClaimCheque> builder)
        {
            builder.ToTable("claims_checks");

            builder.HasNoKey();

            builder.Property(x => x.claimNo).IsRequired(false);
            builder.Property(x => x.checkNumber).HasColumnType("decimal(18,2)").IsRequired(false);
            builder.Property(x => x.checkStatus).IsRequired(false);
            builder.Property(x => x.dateIssued).IsRequired(false);
            builder.Property(x => x.checkAmount).HasColumnType("decimal(18,2)").IsRequired(false);
            builder.Property(x => x.checkType).IsRequired(false);
            builder.Property(x => x.checkRemarks).IsRequired(false);
            builder.Property(x => x.dateRemitted).IsRequired(false);
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

        private void ConfigureVeterans(EntityTypeBuilder<Veteran> builder)
        {
            builder.ToTable("claims_veteran");

            builder.HasKey(x => x.vdmsno);

            builder.Property(x => x.lastName).IsRequired(false);
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
            builder.Property(x => x.dateOfDeath).IsRequired(false);
            builder.Property(x => x.causeOfDeath).IsRequired(false);
            builder.Property(x => x.placeOfDeath).IsRequired(false);
            builder.Property(x => x.sex).IsRequired(false);
            builder.Property(x => x.country).IsRequired(false);
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

        private void ConfigureBenefitCodes(EntityTypeBuilder<BenefitCode> builder)
        {
            builder.ToTable("mdm_bene_code");

            builder.HasKey(x => x.benefitCode);

            builder.Property(x => x.id).IsRequired(true);
            builder.Property(x => x.benefit).IsRequired(true);
            builder.Property(x => x.benefitAmount).HasColumnType("decimal(10,2)").IsRequired(false);
            builder.Property(x => x.benefitStat).IsRequired(false);
        }
    }
}
