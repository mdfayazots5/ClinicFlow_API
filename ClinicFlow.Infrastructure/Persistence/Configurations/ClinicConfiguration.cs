using ClinicFlow.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicFlow.Infrastructure.Persistence.Configurations
{
    public class ClinicConfiguration : IEntityTypeConfiguration<Clinic>
    {
        public void Configure(EntityTypeBuilder<Clinic> builder)
        {
            builder.HasKey(c => c.ClinicId);
            builder.Property(c => c.Name).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Address).IsRequired().HasMaxLength(200);
            builder.Property(c => c.CreatedAt).HasDefaultValueSql("GETDATE()");
            builder.HasMany(c=> c.Doctors).WithOne(d=> d.Clinic).HasForeignKey(d => d.ClinicId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
