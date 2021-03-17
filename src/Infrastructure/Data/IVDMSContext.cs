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

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAccess> UserAccess { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Role>(ConfigureRole);
            builder.Entity<User>(ConfigureUser);
            builder.Entity<UserAccess>(ConfigureUserAccess);
        }

        private void ConfigureRole(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("vbms_role");

            builder.HasKey(x => x.userRole);

            builder.Property(x => x.Id).UseIdentityColumn().IsRequired(true);
        }

        private void ConfigureUser(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("vbms_users");

            builder.HasKey(x => x.userName);

            builder.Property(x => x.id).UseIdentityColumn();

            builder.Property(x => x.userName).IsRequired(true);
            builder.Property(x => x.userPassword).IsRequired(false);
            builder.Property(x => x.fullName).IsRequired(false);
            builder.Property(x => x.email).IsRequired(false);
            builder.Property(x => x.passwordExpiry).IsRequired(false);
            builder.Property(x => x.userEnabled).IsRequired(false);
            builder.Property(x => x.lastLogin).IsRequired(false);
            builder.Property(x => x.userRole).IsRequired(false);
            builder.Property(x => x.dockOff).IsRequired(false);
            builder.Property(x => x.divisionCode).IsRequired(false);
            builder.Property(x => x.createdBy).IsRequired(false);
            builder.Property(x => x.dateCreated).IsRequired(false);
            builder.Property(x => x.modifiedBy).IsRequired(false);
            builder.Property(x => x.dateModified).IsRequired(false);
        }

        public void ConfigureUserAccess(EntityTypeBuilder<UserAccess> builder)
        {
            builder.ToTable("vbms_useraccess");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.userRole).IsRequired(false);
            builder.Property(x => x.adminV).IsRequired(false);
            builder.Property(x => x.adminC).IsRequired(false);
            builder.Property(x => x.adminU).IsRequired(false);
            builder.Property(x => x.adminD).IsRequired(false);
            builder.Property(x => x.veteraninfoC).IsRequired(false);
            builder.Property(x => x.veteraninfoU).IsRequired(false);
            builder.Property(x => x.oldageC).IsRequired(false);
            builder.Property(x => x.oldageU).IsRequired(false);
            builder.Property(x => x.deathC).IsRequired(false);
            builder.Property(x => x.deathU).IsRequired(false);
            builder.Property(x => x.burialC).IsRequired(false);
            builder.Property(x => x.burialU).IsRequired(false);
            builder.Property(x => x.disabilityC).IsRequired(false);
            builder.Property(x => x.disabilityU).IsRequired(false);
            builder.Property(x => x.educationalC).IsRequired(false);
            builder.Property(x => x.educationalU).IsRequired(false);
            builder.Property(x => x.accruedC).IsRequired(false);
            builder.Property(x => x.accruedU).IsRequired(false);
            builder.Property(x => x.BenefitU).IsRequired(false);
            builder.Property(x => x.BenefitV).IsRequired(false);
            builder.Property(x => x.Reassign).IsRequired(false);
            builder.Property(x => x.Cancel).IsRequired(false);
            builder.Property(x => x.UpdateBenefitStatus).IsRequired(false);
            builder.Property(x => x.ValidationUpdates).IsRequired(false);
            builder.Property(x => x.PMonitoring).IsRequired(false);
            builder.Property(x => x.NMonitoring).IsRequired(false);
        }
    }
}
