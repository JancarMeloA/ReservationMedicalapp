using MedicalReservationsApp.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace MedicalReservationsApp.Server.interfaces
{
    public interface IProfesionalUsersController
    {
       public Task<ActionResult<IEnumerable<ProfessionalUsers>>> GetProfessionalUsers();
       public  Task<ActionResult<ProfessionalUsers>> GetProfessionalUsers(int id);
       public Task<IActionResult> PutProfessionalUsers(int id, ProfessionalUsers professionalUsers);
       public Task<ActionResult<ProfessionalUsers>> PostProfessionalUsers(ProfessionalUsers professionalUsers);
       public Task<IActionResult> DeleteProfessionalUsers(int id);
    }
}
