using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalReservationsApp.Server.Models
{
    public class Contacts
    {
        [Key]
        public int IdContacts { get; set; }
        public int IdContactType { get; set; }
        [ForeignKey("IdContactType")]
        public virtual ContactType? ContactType { get; set; }
    }
}
