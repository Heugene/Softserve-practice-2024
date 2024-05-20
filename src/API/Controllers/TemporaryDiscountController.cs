using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Infrastructure.Data;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemporaryDiscountController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TemporaryDiscountController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TemporaryDiscount
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TemporaryDiscount>>> GetTemporaryDiscounts()
        {
            return await _context.TemporaryDiscounts.ToListAsync();
        }

        // GET: api/TemporaryDiscount/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TemporaryDiscount>> GetTemporaryDiscount(int id)
        {
            var temporaryDiscount = await _context.TemporaryDiscounts.FindAsync(id);

            if (temporaryDiscount == null)
            {
                return NotFound();
            }

            return temporaryDiscount;
        }

        // PUT: api/TemporaryDiscount/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTemporaryDiscount(int id, TemporaryDiscount temporaryDiscount)
        {
            if (id != temporaryDiscount.Id)
            {
                return BadRequest();
            }

            _context.Entry(temporaryDiscount).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TemporaryDiscountExists(id))
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

        // POST: api/TemporaryDiscount
        [HttpPost]
        public async Task<ActionResult<TemporaryDiscount>> PostTemporaryDiscount(TemporaryDiscount temporaryDiscount)
        {
            _context.TemporaryDiscounts.Add(temporaryDiscount);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTemporaryDiscount", new { id = temporaryDiscount.Id }, temporaryDiscount);
        }

        // DELETE: api/TemporaryDiscount/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTemporaryDiscount(int id)
        {
            var temporaryDiscount = await _context.TemporaryDiscounts.FindAsync(id);
            if (temporaryDiscount == null)
            {
                return NotFound();
            }

            _context.TemporaryDiscounts.Remove(temporaryDiscount);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TemporaryDiscountExists(int id)
        {
            return _context.TemporaryDiscounts.Any(e => e.Id == id);
        }
    }
}
