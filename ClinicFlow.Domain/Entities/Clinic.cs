using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicFlow.Domain.Entities
{
    public class Clinic
    {
        public Int64 ClinicId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string CreatedAt { get; set; }
    }
}
