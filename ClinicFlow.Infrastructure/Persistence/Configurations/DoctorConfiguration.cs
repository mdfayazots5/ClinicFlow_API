using ClinicFlow.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicFlow.Infrastructure.Persistence.Configurations
{
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(d => d.DoctorId);
            builder.Property(d => d.Name).IsRequired().HasMaxLength(100);
            builder.Property(d => d.Specialization).IsRequired().HasMaxLength(10);
            builder.Property(d => d.IsActive).HasDefaultValue(true);
            builder.HasOne(d => d.Clinic).WithMany(c => c.Doctors).HasForeignKey(d => d.ClinicId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
