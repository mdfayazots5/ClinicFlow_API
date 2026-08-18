using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicFlow.Domain.Entities
{
    public class DoctorLeave
    {
        [Key]
        public Int64 DoctorLeaveId { get; set; }
        [Required]
        public DateOnly LeaveDate { get; set; }
        [Required]
        public string Reason { get; set; }

        [ForeignKey(nameof(Doctor))]
        public Int64 DoctorId { get; set; }
        public Doctor Doctor { get; set; }

    }
}
