using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_PROJET_07449.DataAccess.Dtos;

[Table("Patients")]
public class PatientDTO : IDTO {

    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(64)]
    public string FirstName { get; set; }


    [Required]
    [StringLength(64)]
    public string LastName { get; set; }


    [Required]
    [StringLength(12)]
    public string HealthCardNumber { get; set; }


    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime CreatedDate { get; set; }



    public List<AppointmentDTO> Appointments { get; set; }

    public PatientDTO() { }

    public PatientDTO(string firstName, string lastName, string healthCardNumber) { 
        this.FirstName = firstName;
        this.LastName = lastName;
        this.HealthCardNumber = healthCardNumber;
    }

}
