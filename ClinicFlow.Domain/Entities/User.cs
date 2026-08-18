using ClinicFlow.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicFlow.Domain.Entities
{
    public class User
    {
        [Key]
        public Int64 UserId { get; set; }

        [Required, MaxLength(50), MinLength(3)]
        public string Email { get; set; }
        [Required]
        public string PasswordHash { get; set; }
        [Required]

        public Role Role { get; set; }

        [ForeignKey(nameof(Doctor))]
        public Int64 DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}
