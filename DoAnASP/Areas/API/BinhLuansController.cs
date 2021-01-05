using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DoAnASP.Areas.Admin.Models;
using DoAnASP.Areas.User.Data;

namespace DoAnASP.Areas.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class BinhLuansController : ControllerBase
    {
        private readonly DpContext _context;

        public BinhLuansController(DpContext context)
        {
            _context = context;
        }

        // GET: api/BinhLuans
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BinhLuan>>> GetBinhLuans()
        {
            return await _context.BinhLuans.ToListAsync();
        }

        // GET: api/BinhLuans/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BinhLuan>> GetBinhLuan(int id)
        {
            var binhLuan = await _context.BinhLuans.FindAsync(id);

            if (binhLuan == null)
            {
                return NotFound();
            }

            return binhLuan;
        }

        // PUT: api/BinhLuans/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBinhLuan(int id, BinhLuan binhLuan)
        {
            if (id != binhLuan.IDBL)
            {
                return BadRequest();
            }

            _context.Entry(binhLuan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BinhLuanExists(id))
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

        // POST: api/BinhLuans
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<BinhLuan>> PostBinhLuan(BinhLuan binhLuan)
        {
            _context.BinhLuans.Add(binhLuan);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBinhLuan", new { id = binhLuan.IDBL }, binhLuan);
        }

        // DELETE: api/BinhLuans/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<BinhLuan>> DeleteBinhLuan(int id)
        {
            var binhLuan = await _context.BinhLuans.FindAsync(id);
            if (binhLuan == null)
            {
                return NotFound();
            }

            _context.BinhLuans.Remove(binhLuan);
            await _context.SaveChangesAsync();

            return binhLuan;
        }

        private bool BinhLuanExists(int id)
        {
            return _context.BinhLuans.Any(e => e.IDBL == id);
        }
    }
}
