using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PVAO.ApplicationCore.Entities.Structure;

namespace PVAO.Infrastructure.Data
{
    public class PVAOContext : DbContext 
    {
        public PVAOContext(DbContextOptions<PVAOContext> options) : base(options)
        {
        }

        public DbSet<Settings> Settings { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Settings>(ConfigureSettings);
        }

        private void ConfigureSettings(EntityTypeBuilder<Settings> builder)
        {
            builder.ToTable("Settings");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.FromEmail).IsRequired(true);
            builder.Property(x => x.FromName).IsRequired(true);
            builder.Property(x => x.ServerName).IsRequired(true);
            builder.Property(x => x.SMTPPort).IsRequired(true);
            builder.Property(x => x.Username).IsRequired(true);
            builder.Property(x => x.Password).IsRequired(true);
            builder.Property(x => x.EnableSSL).IsRequired(true);
            builder.Property(x => x.MaxSignOnAttempts).IsRequired(true);
            builder.Property(x => x.ExpiresIn).IsRequired(true);
            builder.Property(x => x.MinPasswordLength).IsRequired(true);
            builder.Property(x => x.MinSpecialCharacters).IsRequired(true);
            builder.Property(x => x.EnforcePasswordHistory).IsRequired(true);
            builder.Property(x => x.ActivationLinkExpiresIn).IsRequired(true);
            builder.Property(x => x.BaseUrl).IsRequired(false); 
            builder.Property(x => x.CreatedBy).IsRequired(true);
            builder.Property(x => x.DateCreated).IsRequired(true);
            builder.Property(x => x.UpdatedBy).IsRequired(false);
            builder.Property(x => x.DateUpdated).IsRequired(false);
        }
    }
}