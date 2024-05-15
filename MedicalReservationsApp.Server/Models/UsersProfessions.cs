using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalReservationsApp.Server.Models
{
    public class UsersProfessions
    {
        [Key]
        public int IdUsersProfessions { get; set; }

        [StringLength(maximumLength: 100)]
        public string Professions { get; set; }
        public int IdSpecialties { get; set; }
        [ForeignKey("IdSpecialties")]
        public virtual Specialties Specialties { get; set; }
    }
}
