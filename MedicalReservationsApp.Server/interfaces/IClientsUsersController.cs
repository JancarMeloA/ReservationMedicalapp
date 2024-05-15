using MedicalReservationsApp.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace MedicalReservationsApp.Server.interfaces
{
    public interface IClientsUsersController
    {
        public Task<ActionResult<IEnumerable<ClientsUsers>>> GetClientUsers();
        public Task<ActionResult<ClientsUsers>> PostClientUsers(ClientsUsers clientsUsers);
    }
}
