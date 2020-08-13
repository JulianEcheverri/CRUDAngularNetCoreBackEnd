using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CRUDAngular;
using CRUDAngular.Models;

namespace CRUDAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarjetaDeCreditoController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public TarjetaDeCreditoController(AplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TarjetaDeCredito
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TarjetaDeCredito>>> GetTarjetasDeCredito()
        {
            return await _context.TarjetasDeCredito.ToListAsync();
        }

        // GET: api/TarjetaDeCredito/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TarjetaDeCredito>> GetTarjetaDeCredito(int id)
        {
            var tarjetaDeCredito = await _context.TarjetasDeCredito.FindAsync(id);

            if (tarjetaDeCredito == null)
            {
                return NotFound();
            }

            return tarjetaDeCredito;
        }

        // PUT: api/TarjetaDeCredito/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTarjetaDeCredito(int id, TarjetaDeCredito tarjetaDeCredito)
        {
            if (id != tarjetaDeCredito.Id)
            {
                return BadRequest();
            }

            _context.Entry(tarjetaDeCredito).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TarjetaDeCreditoExists(id))
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

        // POST: api/TarjetaDeCredito
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TarjetaDeCredito>> PostTarjetaDeCredito(TarjetaDeCredito tarjetaDeCredito)
        {
            _context.TarjetasDeCredito.Add(tarjetaDeCredito);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTarjetaDeCredito", new { id = tarjetaDeCredito.Id }, tarjetaDeCredito);
        }

        // DELETE: api/TarjetaDeCredito/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TarjetaDeCredito>> DeleteTarjetaDeCredito(int id)
        {
            var tarjetaDeCredito = await _context.TarjetasDeCredito.FindAsync(id);
            if (tarjetaDeCredito == null)
            {
                return NotFound();
            }

            _context.TarjetasDeCredito.Remove(tarjetaDeCredito);
            await _context.SaveChangesAsync();

            return tarjetaDeCredito;
        }

        private bool TarjetaDeCreditoExists(int id)
        {
            return _context.TarjetasDeCredito.Any(e => e.Id == id);
        }
    }
}
