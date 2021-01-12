using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IMDB_API.Models;

namespace IMDB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmeGeneroesController : ControllerBase
    {
        private readonly IMDBContext _context;

        public FilmeGeneroesController(IMDBContext context)
        {
            _context = context;
        }

        // GET: api/FilmeGeneroes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FilmeGenero>>> GetFilmeGenero()
        {
            return await _context.FilmeGenero.ToListAsync();
        }

        // GET: api/FilmeGeneroes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FilmeGenero>> GetFilmeGenero(int id)
        {
            var filmeGenero = await _context.FilmeGenero.FindAsync(id);

            if (filmeGenero == null)
            {
                return NotFound();
            }

            return filmeGenero;
        }

        // PUT: api/FilmeGeneroes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFilmeGenero(int id, FilmeGenero filmeGenero)
        {
            if (id != filmeGenero.Tconst)
            {
                return BadRequest();
            }

            _context.Entry(filmeGenero).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FilmeGeneroExists(id))
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

        // POST: api/FilmeGeneroes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<FilmeGenero>> PostFilmeGenero([FromBody] FilmeGeneroTemp filmeGeneroTemp)
        {
            var gen = await _context.Genero.FirstAsync(x => x.Nome == filmeGeneroTemp.Genero);

            var filmeGenero = new FilmeGenero
            {
                IdGenero = gen.IdGenero,
                Tconst = filmeGeneroTemp.Tconst
            };

            await _context.FilmeGenero.AddAsync(filmeGenero);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {

                return Conflict();
            }

            return CreatedAtAction("GetFilmeGenero", new { id = filmeGenero.Tconst }, filmeGenero);
        }

        // DELETE: api/FilmeGeneroes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<FilmeGenero>> DeleteFilmeGenero(int id)
        {
            var filmeGenero = await _context.FilmeGenero.FindAsync(id);
            if (filmeGenero == null)
            {
                return NotFound();
            }

            _context.FilmeGenero.Remove(filmeGenero);
            await _context.SaveChangesAsync();

            return filmeGenero;
        }

        private bool FilmeGeneroExists(int id)
        {
            return _context.FilmeGenero.Any(e => e.Tconst == id);
        }
    }
}
