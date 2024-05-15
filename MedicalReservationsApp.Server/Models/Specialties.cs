using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalReservationsApp.Server.Models
{
    public class Specialties
    {
        [Key]
        public int IdSpecialties { get; set; }
        [StringLength(maximumLength: 120)]
        public string specialities { get; set; }
    }
}
