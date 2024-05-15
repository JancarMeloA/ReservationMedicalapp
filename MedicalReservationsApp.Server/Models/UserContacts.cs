
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalReservationsApp.Server.Models
{
    public class UserContacts
    {
        [Key]
        public int IdUserContacts { get; set; }
        public int IdContacts { get; set; }
        [ForeignKey("IdContacts")]
        public virtual Contacts Contacts {get; set;}
    }
}
