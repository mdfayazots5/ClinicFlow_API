using ClinicFlow.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicFlow.Infrastructure.Persistence.Configurations
{
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Appointment> builder)
        {
            builder.HasKey(a => a.AppointmentId);
            builder.Property(a => a.Status).IsRequired();
            builder.HasOne(a => a.Patient).WithMany(p => p.Appointment).HasForeignKey(a => a.PatientId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(a => a.Doctor).WithMany(d => d.Appointment).HasForeignKey(a => a.DoctorId).OnDelete(DeleteBehavior.Restrict);
            builder.Property(a => a.StartTime).IsRequired();
            builder.Property(a => a.EndTime).IsRequired();
            builder.Property(a => a.CreatedBy).IsRequired();
            builder.Property(a => a.CreatedAt).IsRequired();
            builder.Property(a => a.UpdatedAt);
        }
    }
}
