using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PVAO.ApplicationCore.Entities.Security;
using PVAO.ApplicationCore.Entities.Structure;

namespace PVAO.Infrastructure.Data
{
    public class PVAOContext : DbContext
    {
        public PVAOContext(DbContextOptions<PVAOContext> options) : base(options)
        {
        }

        public DbSet<Company> Company { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<PasswordHistory> PasswordHistories { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Settings> Settings { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Company>(ConfigureCompany);
            builder.Entity<Page>(ConfigurePage);
            builder.Entity<PasswordHistory>(ConfigurePasswordHistory);
            builder.Entity<Role>(ConfigureRole);
            builder.Entity<Settings>(ConfigureSettings);
        }

        private void ConfigureCompany(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("Company");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.CompanyName).HasMaxLength(250).IsRequired(true);
            builder.Property(x => x.Address).HasMaxLength(650).IsRequired(true);
            builder.Property(x => x.EmailAddress).HasMaxLength(150).IsRequired(true);
            builder.Property(x => x.PhoneNumber).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.MobileNumber).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.AboutUs).IsRequired(true);
            builder.Property(x => x.Facebook).HasMaxLength(150).IsRequired(false);
            builder.Property(x => x.LogoPath).HasMaxLength(250).IsRequired(true);
        }

        private void ConfigurePage(EntityTypeBuilder<Page> builder)
        {
            builder.ToTable("Page");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.PageName).HasMaxLength(250).IsRequired(true);
            builder.Property(x => x.Description).HasMaxLength(250).IsRequired(true);
            builder.Property(x => x.UrlPath).HasMaxLength(150).IsRequired(true);
            builder.Property(x => x.ParentMenu).HasMaxLength(50).IsRequired(false);
            builder.Property(x => x.Icon).HasMaxLength(50).IsRequired(false);
            builder.Property(x => x.Order).IsRequired(true);
            builder.Property(x => x.IsParent).IsRequired(true);
            builder.Property(x => x.Visible).IsRequired(true);
            builder.Property(x => x.AccessibleByAll).IsRequired(true);
            builder.Property(x => x.Active).IsRequired(true);
            builder.Property(x => x.DateCreated).IsRequired(true);
        }

        private void ConfigurePasswordHistory(EntityTypeBuilder<PasswordHistory> builder)
        {
            builder.ToTable("PasswordHistory");

            builder.HasKey(t => new { t.Id, t.UserID });
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Password).IsRequired(true);
            builder.Property(x => x.DateCreated).IsRequired(true);
        }

        private void ConfigureRole(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Role");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.RoleName).HasMaxLength(250).IsRequired(true);
            builder.Property(x => x.Description).HasMaxLength(350).IsRequired(true);
            builder.Property(x => x.CreatedBy).IsRequired(true);
            builder.Property(x => x.DateCreated).IsRequired(true);
            builder.Property(x => x.UpdatedBy).IsRequired(false);
            builder.Property(x => x.DateUpdated).IsRequired(false);
        }

        private void ConfigureSettings(EntityTypeBuilder<Settings> builder)
        {
            builder.ToTable("Settings");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.FromEmail).HasMaxLength(150).IsRequired(true);
            builder.Property(x => x.FromName).HasMaxLength(150).IsRequired(true);
            builder.Property(x => x.ServerName).HasMaxLength(250).IsRequired(true);
            builder.Property(x => x.SMTPPort).IsRequired(true);
            builder.Property(x => x.Username).HasMaxLength(150).IsRequired(true);
            builder.Property(x => x.Password).IsRequired(true);
            builder.Property(x => x.EnableSSL).IsRequired(true);
            builder.Property(x => x.MaxSignOnAttempts).IsRequired(true);
            builder.Property(x => x.ExpiresIn).IsRequired(true);
            builder.Property(x => x.MinPasswordLength).IsRequired(true);
            builder.Property(x => x.MinSpecialCharacters).IsRequired(true);
            builder.Property(x => x.EnforcePasswordHistory).IsRequired(true);
            builder.Property(x => x.ActivationLinkExpiresIn).IsRequired(true);
            builder.Property(x => x.BaseUrl).HasMaxLength(150).IsRequired(false);
            builder.Property(x => x.CreatedBy).IsRequired(true);
            builder.Property(x => x.DateCreated).IsRequired(true);
            builder.Property(x => x.UpdatedBy).IsRequired(false);
            builder.Property(x => x.DateUpdated).IsRequired(false);
        }
    }
}