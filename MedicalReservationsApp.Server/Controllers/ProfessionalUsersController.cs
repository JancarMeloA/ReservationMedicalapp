using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MedicalReservationsApp.Server.DdContext;
using MedicalReservationsApp.Server.Models;
using MedicalReservationsApp.Server.interfaces;

namespace MedicalReservationsApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessionalUsersController : ControllerBase,IProfesionalUsersController
    {
        private readonly ReservationContext _context;

        public ProfessionalUsersController(ReservationContext context)
        {
            _context = context;
        }

        // GET: api/ProfessionalUsers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProfessionalUsers>>> GetProfessionalUsers()
        {
            return await _context.ProfessionalUsers.ToListAsync();
        }

        // GET: api/ProfessionalUsers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProfessionalUsers>> GetProfessionalUsers(int id)
        {
            var professionalUsers = await _context.ProfessionalUsers.FindAsync(id);

            if (professionalUsers == null)
            {
                return NotFound();
            }

            return professionalUsers;
        }

        // PUT: api/ProfessionalUsers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProfessionalUsers(int id, ProfessionalUsers professionalUsers)
        {
            if (id != professionalUsers.IdProfessionalUsers)
            {
                return BadRequest();
            }

            _context.Entry(professionalUsers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProfessionalUsersExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ProfessionalUsers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProfessionalUsers>> PostProfessionalUsers(ProfessionalUsers professionalUsers)
        {
            _context.ProfessionalUsers.Add(professionalUsers);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProfessionalUsers", new { id = professionalUsers.IdProfessionalUsers }, professionalUsers);
        }

        // DELETE: api/ProfessionalUsers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProfessionalUsers(int id)
        {
            var professionalUsers = await _context.ProfessionalUsers.FindAsync(id);
            if (professionalUsers == null)
            {
                return NotFound();
            }

            _context.ProfessionalUsers.Remove(professionalUsers);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProfessionalUsersExists(int id)
        {
            return _context.ProfessionalUsers.Any(e => e.IdProfessionalUsers == id);
        }
    }
}
