using GameLibraryApi.Modules.Items.DTO;

namespace GameLibraryApi.Modules.Items;

public class ItemMapper
{
    public ItemDto GetDto(Item item)
    {
        return new ItemDto()
        {
            Id = item.Id,
            Name = item.Name,
            Description = item.Description,
            Status = item.Status,
            YoutubeUrl = item.YoutubeUrl
        };
    }
    
    public ItemDetailDto GetDto(ItemDetail item)
    {
        return new ItemDetailDto()
        {
            Id = item.Id,
            ItemId = item.ItemId,
            Detail = item.Detail,
        };
    }
    
    public Item GetEntity(ItemCreateDto itemCreateDto)
    {
        return new Item()
        {
            Name = itemCreateDto.Name,
            Description = itemCreateDto.Description,
            Status = itemCreateDto.Status,
            YoutubeUrl = itemCreateDto.YoutubeUrl,
            CreatedAt = DateTime.UtcNow
        };
    }
    
    public ItemDetail GetEntity(ItemDetailCreateDto itemDetailCreateDto)
    {
        return new ItemDetail()
        {
            Detail = itemDetailCreateDto.Detail,
            CreatedAt = DateTime.UtcNow
        };
    }
    
    public Item UpdateEntity(Item item, ItemCreateDto itemCreateDto)
    {
        item.Name = itemCreateDto.Name;
        item.Description = itemCreateDto.Description;
        item.Status = itemCreateDto.Status;
        item.YoutubeUrl = itemCreateDto.YoutubeUrl;
        item.UpdatedAt = DateTime.UtcNow;
        return item;
    }
    
    public ItemDetail UpdateEntity(ItemDetail itemDetail, ItemDetailCreateDto itemDetailCreateDto)
    {
        itemDetail.Detail = itemDetailCreateDto.Detail;
        itemDetail.UpdatedAt = DateTime.UtcNow;
        return itemDetail;
    }
}