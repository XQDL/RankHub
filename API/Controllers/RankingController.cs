#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_RankHub.Models;

namespace API_RankHub.Controllers
{
    [Route("Ranking")]
    [ApiController]
    public class RankingController : ControllerBase
    {
        private readonly RankingContext _context;

        public RankingController(RankingContext context)
        {
            _context = context;
        }

        // GET: api/Ranking
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ranking>>> GetRanking()
        {
            return await _context.Ranking.ToListAsync();
        }

        // GET: api/Ranking/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ranking>> GetRanking(long id)
        {
            var ranking = await _context.Ranking.FindAsync(id);

            if (ranking == null)
            {
                return NotFound();
            }

            return ranking;
        }

        // PUT: api/Ranking/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRanking(long id, Ranking ranking)
        {
            if (id != ranking.Id)
            {
                return BadRequest();
            }

            _context.Entry(ranking).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RankingExists(id))
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

        // POST: api/Ranking
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Ranking>> PostRanking(Ranking ranking)
        {
            _context.Ranking.Add(ranking);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRanking", new { id = ranking.Id }, ranking);
        }

        // DELETE: api/Ranking/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRanking(long id)
        {
            var ranking = await _context.Ranking.FindAsync(id);
            if (ranking == null)
            {
                return NotFound();
            }

            _context.Ranking.Remove(ranking);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RankingExists(long id)
        {
            return _context.Ranking.Any(e => e.Id == id);
        }
    }
}
