namespace GameLibraryApi.Modules.Items;

public class ItemDetail
{
    public int Id { get; set; }
    public int ItemId { get; set; }
    public String Detail { get; set; } = "";
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}