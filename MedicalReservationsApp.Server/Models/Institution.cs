using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MedicalReservationsApp.Server.Models
{
    public class Institution
    {
        [Key]
        public int IdInstitution { get; set; }
        [StringLength(maximumLength: 110)]
        public string InstitutionName { get; set; }
        [StringLength(maximumLength: 110)]
        public string Address { get; set; }


    }
}
