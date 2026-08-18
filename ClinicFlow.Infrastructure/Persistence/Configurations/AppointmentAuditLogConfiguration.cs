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
    public class AppointmentAuditLogConfiguration: IEntityTypeConfiguration<AppointmentAuditLog>
    {
        public void Configure(EntityTypeBuilder <AppointmentAuditLog> builder)
        {
            builder.HasKey(aa => aa.AppointmentAuditLogId);
            builder.Property(aa => aa.ChangedBy).IsRequired();
            builder.Property(aa => aa.OldStatus).IsRequired();
            builder.Property(aa => aa.NewStatus).IsRequired();
            builder.Property(aa => aa.Notes);
            builder.HasOne(aa => aa.Appointment).WithMany(a => a.AppointmentAuditLog).HasForeignKey(aa => aa.AppointmentId);
        }
    }
}
