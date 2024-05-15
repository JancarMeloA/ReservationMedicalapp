using System.ComponentModel.DataAnnotations;

namespace MedicalReservationsApp.Server.Models
{
    public class ContactType
    {
        [Key]
        public int IdContactType { get; set; }

        [StringLength(maximumLength: 15)]
        public string? PhoneNumber { get; set; }
        [StringLength(maximumLength: 120)]
        public string? Email { get; set; }
    }
}
