using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_PROJET_07449.DataAccess.Dtos;

[Table("Appointments")]
public class AppointmentDTO : IDTO {

    [Key]
    public int Id { get; set; }

    [Required]
    public int PatientId { get; set; }

    [Required]
    public int DoctorId { get; set; }

    [Required]
    public int ClinicId { get; set; }

    [Required]
    public DateTime AppointmentDate { get; set; }


    [ForeignKey("PatientId")]
    public PatientDTO Patient { get; set; }

    [ForeignKey("DoctorId")]
    public DoctorDTO Doctor { get; set; }

    [ForeignKey("ClinicId")]
    public ClinicDTO Clinic { get; set; }


    public AppointmentDTO() { }

    public AppointmentDTO(int patientId, int doctorId, int clinicId, DateTime appointmentDate) {
        this.PatientId = patientId;
        this.DoctorId = doctorId;
        this.ClinicId = clinicId;
        this.AppointmentDate = appointmentDate;
    }

}
