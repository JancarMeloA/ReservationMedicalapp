using System.ComponentModel.DataAnnotations;

namespace MedicalReservationsApp.Server.Models
{
    public class UsersTypes
    {
        [Key]
        public int IdUsersTypes { get; set; }
        public  Boolean Profesional { get; set; }
        public Boolean Customer { get; set; }
    }
}
