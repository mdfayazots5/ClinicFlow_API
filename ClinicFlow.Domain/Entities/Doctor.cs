using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicFlow.Domain.Entities
{
    public class Doctor
    {
        [Key]
        public Int64 DoctorId { get; set; }
        public Int64 ClinicId { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        public string Specialization { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; } = true;
        [ForeignKey(nameof(ClinicId))]
        public Clinic Clinic { get; set; }
        public ICollection<DoctorAvailability> DoctorAvailability { get; set; }
        public ICollection<DoctorLeave> DoctorLeave { get; set; }
    }
}
