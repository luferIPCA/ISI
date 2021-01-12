using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IMDB_API.Models;

namespace IMDB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmesController : ControllerBase
    {
        private readonly IMDBContext _context;

        public FilmesController(IMDBContext context)
        {
            _context = context;
        }

        // GET: api/Filmes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Filme>>> GetFilme()
        {
            return await _context.Filme.ToListAsync();
        }

        // GET: api/Filmes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FilmeGet>> GetFilme(int id)
        {
            var filme = await _context.Filme.FindAsync(id);

            if (filme == null)
            {
                return NotFound();
            }

            var generos = new List<string>();

            foreach (var filmeGenero in _context.FilmeGenero.Where(x => x.Tconst == id).ToList())
            {
                var gen = await _context.Genero.FirstOrDefaultAsync(y => y.IdGenero == filmeGenero.IdGenero);

                generos.Add(gen.Nome);
            }

            var filmeGet = new FilmeGet
            {
                OriginalTitle = filme.OriginalTitle,
                TitleType = filme.TitleType,
                PrimaryTitle = filme.PrimaryTitle,
                IsAdult = filme.IsAdult,
                StartYear = filme.StartYear,
                EndYear = filme.EndYear,
                RuntimeMinutes = filme.RuntimeMinutes,
                Tconst = id,
                FilmeGenero = generos
            };

            return filmeGet;
        }


        // GET: api/FilmesNome/5
        [Route("FilmesName/{nome}")]
        [HttpGet]
        public async Task<ActionResult<FilmeGet>> GetFilmeName(string nome)
        {
            var filme = await _context.Filme.FirstOrDefaultAsync(x=>x.OriginalTitle == nome);

            if (filme == null)
            {
                return NotFound();
            }

            var generos = new List<string>();

            foreach (var filmeGenero in _context.FilmeGenero.Where(x => x.Tconst == filme.Tconst).ToList())
            {
                var gen = await _context.Genero.FirstOrDefaultAsync(y => y.IdGenero == filmeGenero.IdGenero);

                generos.Add(gen.Nome);
            }

            var filmeGet = new FilmeGet
            {
                OriginalTitle = filme.OriginalTitle,
                TitleType = filme.TitleType,
                PrimaryTitle = filme.PrimaryTitle,
                IsAdult = filme.IsAdult,
                StartYear = filme.StartYear,
                EndYear = filme.EndYear,
                RuntimeMinutes = filme.RuntimeMinutes,
                Tconst = filme.Tconst,
                FilmeGenero = generos
            };

            return filmeGet;
        }

        // PUT: api/Filmes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFilme(int id, Filme filme)
        {
            if (id != filme.Tconst)
            {
                return BadRequest();
            }

            _context.Entry(filme).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FilmeExists(id))
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

        // POST: api/Filmes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Filme>> PostFilme([FromBody] Filme filme)
        {
            await _context.Filme.AddAsync(filme);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                return Conflict();
            }

            return Ok();
        }

        // DELETE: api/Filmes/5
        [HttpDelete("{nome}")]
        public async Task<ActionResult<Filme>> DeleteFilme(string nome)
        {
            var filme = await _context.Filme.FirstAsync(x=>x.OriginalTitle == nome);
            if (filme == null)
            {
                return NotFound();
            }

            var generos = _context.FilmeGenero.Where(x => x.Tconst == filme.Tconst).ToArray();

            foreach (var genero in generos)
            {
                _context.FilmeGenero.Remove(genero);
                await _context.SaveChangesAsync();
            }

            _context.Filme.Remove(filme);
            await _context.SaveChangesAsync();

            return filme;
        }

        private bool FilmeExists(int id)
        {
            return _context.Filme.Any(e => e.Tconst == id);
        }
    }
}
