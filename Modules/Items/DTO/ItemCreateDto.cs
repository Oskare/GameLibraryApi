namespace GameLibraryApi.Modules.Items.DTO;

public class ItemCreateDto
{
    public String Name { get; set; } = "";
    public String Description { get; set; } = "";
    public Status Status { get; set; } = Status.Backlog;
    public String? YoutubeUrl { get; set; }
}