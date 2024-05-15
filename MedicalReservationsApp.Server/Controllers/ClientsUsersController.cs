using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MedicalReservationsApp.Server.DdContext;
using MedicalReservationsApp.Server.Models;
using MedicalReservationsApp.Server.interfaces;

namespace MedicalReservationsApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientsUsersController : ControllerBase, IClientsUsersController
    {
        private readonly ReservationContext _context;

        public ClientsUsersController ( ReservationContext context){
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClientsUsers>>> GetClientUsers() 
        {
           var showClients = _context.ClientsUsers;
            if (showClients == null)
            {
                return BadRequest();
            }
            
            return await showClients.ToListAsync();

        }
        [HttpPost]
        public async Task<ActionResult<ClientsUsers>> PostClientUsers(ClientsUsers clientsUsers) 
        {
            _context.ClientsUsers.Add(clientsUsers);
            await _context.SaveChangesAsync();

            
                return  CreatedAtAction("newClient",new {id = clientsUsers.IdClientsUsers }, clientsUsers);
            
        }
    }
        
}
