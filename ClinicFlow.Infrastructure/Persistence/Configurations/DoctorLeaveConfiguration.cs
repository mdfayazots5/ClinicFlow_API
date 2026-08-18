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
    public class DoctorLeaveConfiguration : IEntityTypeConfiguration<DoctorLeave>
    {
        public void Configure(EntityTypeBuilder<DoctorLeave> builder)
        {
            builder.HasKey(dl => dl.DoctorLeaveId);
            builder.Property(dl => dl.LeaveDate).IsRequired();
            builder.Property(dl => dl.Reason).IsRequired().HasMaxLength(100);
            builder.HasOne(dl => dl.Doctor).WithMany(d => d.DoctorLeave).HasForeignKey(dl => dl.DoctorId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
