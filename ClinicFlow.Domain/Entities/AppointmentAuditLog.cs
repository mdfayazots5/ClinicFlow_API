using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicFlow.Domain.Entities
{
    public class AppointmentAuditLog
    {
        [Key]
        public Int64 AppointmentAuditLogId { get; set; }
        [ForeignKey(nameof(Appointment))]
        public Int64 AppointmentId { get; set; }

        public Appointment Appointment { get; set; }
        [Required]
        public string ChangedBy { get; set; }
        [Required]
        public string OldStatus { get; set; }
        [Required]
        public string NewStatus { get; set; }
        public string Notes { get; set; }
    }
}
