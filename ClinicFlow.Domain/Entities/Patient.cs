using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicFlow.Domain.Entities
{
    public class Patient
    {
        [Key]
        public Int64 PatientId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Phone { get; set; }
        public string Email { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public ICollection<Appointment> Appointment { get; set; }
    }
}
