using GameLibraryApi.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameLibraryApi.Modules.Items;

[ApiController]
[Authorize]
public class ItemDetailsController(ApplicationDbContext context) : ControllerBase
{
    [HttpGet("items/{itemId}/details")]
    public async Task<ActionResult<IEnumerable<ItemDetail>>> GetItemDetails(int itemId)
    {
        return await context.ItemDetails
            .Where(d => d.ItemId == itemId)
            .OrderBy(d => d.Id)
            .ToListAsync();
    }

    [HttpGet("items/{itemId}/details/{id}")]
    public async Task<ActionResult<ItemDetail>> GetItemDetail(int id)
    {
        var itemDetail = await context.ItemDetails.FindAsync(id);

        if (itemDetail == null)
        {
            return NotFound();
        }

        return itemDetail;
    }

    [HttpPut("items/{itemId}/details/{id}")]
    public async Task<IActionResult> PutItemDetail(int itemId, int id, ItemDetail itemDetail)
    {
        if (id != itemDetail.Id)
        {
            return BadRequest();
        }

        itemDetail.UpdatedAt = DateTime.UtcNow;
        context.Entry(itemDetail).State = EntityState.Modified;

        try
        {
            await context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!ItemDetailExists(id))
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

    [HttpPost("items/{itemId}/details")]
    public async Task<ActionResult<ItemDetail>> PostItemDetail(ItemDetail itemDetail)
    {
        itemDetail.CreatedAt = DateTime.UtcNow;
        context.ItemDetails.Add(itemDetail);
        await context.SaveChangesAsync();

        return CreatedAtAction("GetItemDetail", new { itemId = itemDetail.ItemId, id = itemDetail.Id }, itemDetail);
    }

    [HttpDelete("items/{itemId}/details/{id}")]
    public async Task<IActionResult> DeleteItemDetail(int id)
    {
        var itemDetail = await context.ItemDetails.FindAsync(id);
        if (itemDetail == null)
        {
            return NotFound();
        }

        context.ItemDetails.Remove(itemDetail);
        await context.SaveChangesAsync();

        return NoContent();
    }

    private bool ItemDetailExists(int id)
    {
        return context.ItemDetails.Any(e => e.Id == id);
    }
}