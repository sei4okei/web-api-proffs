using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoAPI.Models;

namespace TodoAPI.Controllers
{
    // Автоматически сгенерированный контроллер, хочешь почитать про это?
    // загляни в usersController.cs
    [Route("api/[controller]")]
    [ApiController]
    public class info_usersController : ControllerBase
    {
        private readonly TodoContext _context;

        public info_usersController(TodoContext context)
        {
            _context = context;
        }

        // GET: api/info_users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<info_users>>> Getinfo_users()
        {
            return await _context.info_users.ToListAsync();
        }

        // GET: api/info_users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<info_users>> Getinfo_users(int id)
        {
            var info_users = await _context.info_users.FindAsync(id);

            if (info_users == null)
            {
                return NotFound();
            }

            return info_users;
        }

        // PUT: api/info_users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putinfo_users(int id, info_users info_users)
        {
            if (id != info_users.Id)
            {
                return BadRequest();
            }

            _context.Entry(info_users).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!info_usersExists(id))
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

        // POST: api/info_users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<info_users>> Postinfo_users(info_users info_users)
        {
            _context.info_users.Add(info_users);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Getinfo_users), new { id = info_users.Id }, info_users);
        }

        // DELETE: api/info_users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteinfo_users(int id)
        {
            var info_users = await _context.info_users.FindAsync(id);
            if (info_users == null)
            {
                return NotFound();
            }

            _context.info_users.Remove(info_users);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool info_usersExists(int id)
        {
            return _context.info_users.Any(e => e.Id == id);
        }
    }
}
