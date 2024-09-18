using GameLibraryApi.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameLibraryApi.Features.ItemDetails
{
    [Route("[controller]")]
    [ApiController]
    public class ItemDetailsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ItemDetailsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /ItemDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemDetail>>> GetItemDetail()
        {
            return await _context.ItemDetails.ToListAsync();
        }

        // TODO: How to route item/<id>/itemdetails here?

        // GET: /ItemDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemDetail>> GetItemDetail(int id)
        {
            var itemDetail = await _context.ItemDetails.FindAsync(id);

            if (itemDetail == null)
            {
                return NotFound();
            }

            return itemDetail;
        }

        // POST: /ItemDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ItemDetail>> PostItemDetail(ItemDetail itemDetail)
        {
            _context.ItemDetails.Add(itemDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetItemDetail", new { id = itemDetail.Id }, itemDetail);
        }

        // DELETE: /ItemDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItemDetail(int id)
        {
            var itemDetail = await _context.ItemDetails.FindAsync(id);
            if (itemDetail == null)
            {
                return NotFound();
            }

            _context.ItemDetails.Remove(itemDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ItemDetailExists(int id)
        {
            return _context.ItemDetails.Any(e => e.Id == id);
        }
    }
}