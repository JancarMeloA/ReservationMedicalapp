using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalReservationsApp.Server.Models
{
    public class ProfessionalUsers
    {
        [Key]
        [DataType("int")]
        public int IdProfessionalUsers { get; set; }
        public int IdUsersTypes { get; set; }
        [ForeignKey("IdUsersTypes")]
        public virtual UsersTypes UsersTypes { get; set; }
        public int IdInstitution { get; set; }
        [ForeignKey("IdInstitution")]
        public virtual Institution Institution { get; set; }

        public int IdUsersProfessions { get; set; }
        [ForeignKey("IdUsersProfessions")]
        public virtual UsersProfessions UsersProfessions { get; set; }
        public int IdUserContacts { get; set; }
        [ForeignKey("IdUserContacts")]
        public virtual UserContacts UserContacts { get; set; }
        [Required]
        [StringLength(maximumLength:70)]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength:70)]
        public string LastName { get; set; }
        [Required]
        [StringLength(maximumLength: 15)]
        public string Gender { get; set; }
        [Required]
        [StringLength(maximumLength: 110)]
        public string Email { set; get; }
        [Required]
        [StringLength(maximumLength: 120)]
        public string Password { set; get; }
        [DataType("date")]
        public DateTime DateTimeCreated { get; set; }
    }
}
