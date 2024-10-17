using GameLibraryApi.Context;
using GameLibraryApi.Modules.Items.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameLibraryApi.Modules.Items;

[ApiController]
[Authorize]
public class ItemController(ApplicationDbContext context, ItemMapper mapper) : ControllerBase
{
    [HttpGet("items")]
    public async Task<ActionResult<IEnumerable<ItemDto>>> GetItems(
        [FromQuery] string? search = null,
        [FromQuery] int page = 1,
        [FromQuery] int pageSize = 10
    )
    {
        var query = context.Items.AsQueryable();

        // Search
        if (!string.IsNullOrWhiteSpace(search))
        {
            query = query
                .Where(i => i.Name.Contains(search) || i.Description.Contains(search));
        }

        // Pagination
        var totalItems = await query.CountAsync();
        var totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

        var items = query
            .OrderBy(i => i.Name)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .Select(i => mapper.Map(i))
            .ToList();

        return Ok(new
        {
            TotalItems = totalItems,
            TotalPages = totalPages,
            CurrentPage = page,
            PageSize = pageSize,
            Items = items
        });
    }

    [HttpGet("items/{id}")]
    public async Task<ActionResult<ItemDto>> GetItem(int id)
    {
        var item = await context.Items.FindAsync(id);

        if (item == null)
        {
            return NotFound();
        }

        return mapper.Map(item);
    }

    [HttpPut("items/{id}")]
    public async Task<IActionResult> PutItem(int id, ItemCreateDto itemDto)
    {
        var existing = await context.Items.FindAsync(id);

        if (existing == null)
        {
            return NotFound();
        }

        var item = mapper.Map(existing, itemDto);

        try
        {
            await context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!ItemExists(id))
            {
                return NotFound();
            }
            throw;
        }

        return NoContent();
    }

    [HttpPut("items/{id}/status")]
    public async Task<IActionResult> PutStatus(int id, [FromBody] Status status)
    {
        var item = await context.Items.FindAsync(id);

        if (item == null)
        {
            return NotFound();
        }

        item.Status = status;
        item.UpdatedAt = DateTime.UtcNow;

        await context.SaveChangesAsync();

        return NoContent();
    }

    [HttpPost("items")]
    public async Task<ActionResult<ItemDto>> PostItem(ItemCreateDto itemDto)
    {
        var item = mapper.Map(itemDto);
        context.Items.Add(item);
        await context.SaveChangesAsync();

        return CreatedAtAction("GetItem", new { id = item.Id }, mapper.Map(item));
    }

    [HttpDelete("items/{id}")]
    public async Task<IActionResult> DeleteItem(int id)
    {
        var item = await context.Items.FindAsync(id);
        if (item == null)
        {
            return NotFound();
        }

        context.Items.Remove(item);
        await context.SaveChangesAsync();

        return NoContent();
    }
    
    [HttpGet("items/{itemId}/details")]
    public async Task<ActionResult<IEnumerable<ItemDetailDto>>> GetItemDetails(int itemId)
    {
        return await context.ItemDetails
            .Where(d => d.ItemId == itemId)
            .OrderBy(d => d.Id)
            .Select(d => mapper.Map(d))
            .ToListAsync();
    }

    [HttpGet("items/{itemId}/details/{id}")]
    public async Task<ActionResult<ItemDetailDto>> GetItemDetail(int id)
    {
        var itemDetail = await context.ItemDetails.FindAsync(id);

        if (itemDetail == null)
        {
            return NotFound();
        }

        return mapper.Map(itemDetail);
    }

    [HttpPut("items/{itemId}/details/{id}")]
    public async Task<IActionResult> PutItemDetail(int itemId, int id, ItemDetailCreateDto itemDetailDto)
    {
        var existing = await context.ItemDetails.FindAsync(id);
        if (existing == null)
        {
            return NotFound();
        }

        var itemDetail = mapper.Map(existing, itemDetailDto);

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
            throw;
        }

        return NoContent();
    }

    [HttpPost("items/{itemId}/details")]
    public async Task<ActionResult<ItemDetailDto>> PostItemDetail(int itemId, ItemDetailCreateDto itemDetailDto)
    {
        var itemDetail = mapper.Map(itemDetailDto);
        itemDetail.ItemId = itemId;
        context.ItemDetails.Add(itemDetail);
        await context.SaveChangesAsync();

        return CreatedAtAction(
            "GetItemDetail", 
            new { itemId = itemDetail.ItemId, id = itemDetail.Id },
            mapper.Map(itemDetail));
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

    private bool ItemExists(int id)
    {
        return context.Items.Any(e => e.Id == id);
    }
}