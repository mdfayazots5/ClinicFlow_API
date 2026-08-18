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
    public class DoctorAvailabilityConfiguration : IEntityTypeConfiguration<DoctorAvailability>
    {
        public void Configure(EntityTypeBuilder<DoctorAvailability> builder)
        {
            builder.HasKey(da => da.AvailabilityId);
            builder.Property(da => da.DayOfWeek).IsRequired();
            builder.Property(da => da.StartTime).IsRequired();
            builder.Property(da => da.EndTime).IsRequired();
            builder.HasOne(da => da.Doctor).WithMany(d => d.DoctorAvailability).HasForeignKey(da => da.DoctorId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
