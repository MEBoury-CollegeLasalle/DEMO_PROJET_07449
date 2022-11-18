using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_PROJET_07449.DataAccess.Dtos;

[Table("Clinic")]
public class ClinicDTO : IDTO {

    [Column("Id")]
    [Key]
    public int Id { get; set; }

    [Column("Name")]
    [Required]
    [StringLength(128)]
    public string Name { get; set; }

    [Column("StreetNumber")]
    public int? StreetNumber { get; set; }

    [Column("Street")]
    [StringLength(64)]
    public string? Street { get; set; }

    [Column("City")]
    [StringLength(64)]
    public string? City { get; set; }

    [Column("Region")]
    [StringLength(64)]
    public string? Region { get; set; }

    [Column("Country")]
    [StringLength(64)]
    public string? Country { get; set; }

    [Column("PostalCode")]
    [StringLength(16)]
    public string? PostalCode { get; set; }



    public List<AppointmentDTO> Appointments { get; set; }


    public ClinicDTO(string name, 
        int? streetNumber = null, 
        string? street = null, 
        string? city = null, 
        string? region = null, 
        string? country = null, 
        string? postalCode = null) {

        this.Name = name;
        this.StreetNumber = streetNumber;
        this.Street = street;
        this.City = city;
        this.Region = region;
        this.Country = country;
        this.PostalCode = postalCode;
    }

}
