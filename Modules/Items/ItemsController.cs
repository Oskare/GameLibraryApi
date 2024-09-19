using GameLibraryApi.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameLibraryApi.Modules.Items;

[Route("items")]
[ApiController]
[Authorize]
public class ItemsController(ApplicationDbContext context) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Item>>> GetItems(
        [FromQuery] string? search = null,
        [FromQuery] int page = 1,
        [FromQuery] int pageSize = 10
    )
    {
        var query = context.Items.AsQueryable();

        // Search
        if (!string.IsNullOrWhiteSpace(search))
        {
            query = query.Where(i => i.Name.Contains(search) || i.Description.Contains(search));
        }

        // Pagination
        var totalItems = await query.CountAsync();
        var totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

        var items = query
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .OrderBy(i => i.Name)
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

    [HttpGet("{id}")]
    public async Task<ActionResult<Item>> GetItem(int id)
    {
        var item = await context.Items.FindAsync(id);

        if (item == null)
        {
            return NotFound();
        }

        return item;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutItem(int id, Item item)
    {
        if (id != item.Id)
        {
            return BadRequest();
        }

        item.UpdatedAt = DateTime.UtcNow;
        context.Entry(item).State = EntityState.Modified;

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
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    [HttpPut("{id}/status")]
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

    [HttpPost]
    public async Task<ActionResult<Item>> PostItem(Item item)
    {
        item.CreatedAt = DateTime.UtcNow;
        context.Items.Add(item);
        await context.SaveChangesAsync();

        return CreatedAtAction("GetItem", new { id = item.Id }, item);
    }

    [HttpDelete("{id}")]
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

    private bool ItemExists(int id)
    {
        return context.Items.Any(e => e.Id == id);
    }
}