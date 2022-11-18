using DEMO_PROJET_07449.DataAccess.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_PROJET_07449.DataAccess.Contextes;
public class ProjectContext : DbContext, IContext {

    public DbSet<ClinicDTO> Clinics { get; set; }
    public DbSet<DoctorDTO> Doctors { get; set; }
    public DbSet<PatientDTO> Patients { get; set; }
    public DbSet<AppointmentDTO> Appointments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options) {
        options.UseSqlServer("Server=.\\SQL2019EXPRESS;Database=db_project_07449;Integrated security=true;TrustServerCertificate=true;");
    }
}
