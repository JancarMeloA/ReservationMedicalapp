using Microsoft.EntityFrameworkCore;
using MedicalReservationsApp.Server.Models;
namespace MedicalReservationsApp.Server.DdContext
{
    public class ReservationContext: DbContext 
    {
        public ReservationContext()
        {
    
        }

        public ReservationContext(DbContextOptions<ReservationContext>options):base(options) 
        {
        }

        // Professional:
       public DbSet<ProfessionalUsers> ProfessionalUsers { get; set; }

        // other Tables:
       public DbSet<Institution> Institutions { get; set; }
        public DbSet<UserContacts> UserContacts { get; set; }
        public DbSet<ContactType> ContactTypes { get; set; }
        public DbSet<Contacts> Contacts { get; set; }
        public DbSet<UsersTypes> UsersTypes { get; set; }
        public DbSet<UsersProfessions> UsersProfessions { get; set; }
        public DbSet<Specialties> Specialties { get; set; }

        //Client:

        public DbSet<ClientsUsers> ClientsUsers { get; set; }
    }
}
