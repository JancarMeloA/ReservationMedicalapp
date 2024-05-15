using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalReservationsApp.Server.Models
{
    public class ClientsUsers
    {
        [Key]
        public int IdClientsUsers { get; set; }
        public int IdUserTypes { get; set; }
        [ForeignKey("IdUserTypes")]
        public virtual  UsersTypes UsersTypes { get; set; }

        public int IdContactType {get; set;}
        [ForeignKey("IdContactType")]
        public virtual ContactType ContactType { get; set; }
        [Required]
        [StringLength(maximumLength: 70)]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 70)]
        public string LastName  { get; set; }
        [Required]
        [StringLength(maximumLength: 15)]
        public string Gender { get; set; }
        [Required]
        [StringLength(maximumLength: 120)]
        public string Password { get; set; }
        [DataType("data")]
        public DateTime DateTimeCreated { get; set; }
    }
}
