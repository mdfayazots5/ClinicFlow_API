using ClinicFlow.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicFlow.Infrastructure.Persistence
{
    public class ClinicFlowDbContext : DbContext
    {
        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<Doctor> Doctors { get; set; }

        public ClinicFlowDbContext(DbContextOptions<ClinicFlowDbContext> options) : base(options) { }
    }
}
