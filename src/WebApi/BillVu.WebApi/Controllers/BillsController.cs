using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BillVu.WebApi.Infrastructure;
using BillVu.WebApi.Models;

namespace BillVu.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillsController : ControllerBase
    {
        private readonly BillVuDbContext _context;

        public BillsController(BillVuDbContext context)
        {
            if(context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            _context = context;
        }

        // GET: api/Bills
        [HttpGet]
        [ProducesResponseType(200)]
        public IEnumerable<Bill> GetBills()
        {
            return _context.Bills;
        }

        // GET: api/Bills/5
        [HttpGet("{id}")]
        public IActionResult GetBill([FromRoute] string id)
        {
            if(!Guid.TryParse(id, out Guid billId))
            {
                throw new ArgumentException($"Invalid value in {nameof(id)}");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bill = _context.Bills.SingleOrDefault(b => b.Id == billId);

            if (bill == null)
            {
                return NotFound();
            }

            return Ok(bill);
        }

        // PUT: api/Bills/5
        [HttpPut("{id}")]
        [ProducesResponseType(404)]
        public async Task<IActionResult> PutBill([FromRoute] string id, [FromBody] Bill bill)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bill.Name)
            {
                return BadRequest();
            }

            _context.Entry(bill).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BillExists(id))
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

        // POST: api/Bills
        [HttpPost]
        public async Task<IActionResult> PostBill([FromBody] Bill bill)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Bills.Add(bill);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (BillExists(bill.Name))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetBill", new { id = bill.Name }, bill);
        }

        // DELETE: api/Bills/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBill([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var bill = await _context.Bills.FindAsync(id);
            if (bill == null)
            {
                return NotFound();
            }

            _context.Bills.Remove(bill);
            await _context.SaveChangesAsync();

            return Ok(bill);
        }

        private bool BillExists(string id)
        {
            return _context.Bills.Any(e => e.Name == id);
        }
    }
}