using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicFlow.Domain.Entities
{
    public class DoctorAvailability
    {
        [Key]
        public Int64 AvailabilityId { get; set; }

        [ForeignKey(nameof(Doctor))]
        public Int64 DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        [Required]
        public DayOfWeek DayOfWeek { get; set; }
        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

    }
}

