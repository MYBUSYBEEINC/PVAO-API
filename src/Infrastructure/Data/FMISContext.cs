using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PVAO.ApplicationCore.Entities.Structure;
using System;
using System.Collections.Generic;
using System.Text;

namespace PVAO.Infrastructure.Data
{
    public class FMISContext : DbContext
    {
        public FMISContext(DbContextOptions<FMISContext> options) : base(options)
        {
        }

        public DbSet<Cheque> Cheques { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Cheque>(ConfigureCheque);
        }

        private void ConfigureCheque(EntityTypeBuilder<Cheque> builder)
        {
            builder.ToTable("fm_Cheques");

            builder.HasKey(x => x.ID);

            builder.Property(x => x.DisbursementsID).IsRequired(true);
            builder.Property(x => x.ChequeNumber).IsRequired(false);
            builder.Property(x => x.Amount).HasColumnType("decimal(16,2)").IsRequired(true);
            builder.Property(x => x.ChequeDate).IsRequired(true);
            builder.Property(x => x.BankCode).IsRequired(true);
            builder.Property(x => x.Payee).IsRequired(true);
            builder.Property(x => x.PayeeBankCode).IsRequired(false);
            builder.Property(x => x.CreatedDate).IsRequired(true);
        }
    }
}
