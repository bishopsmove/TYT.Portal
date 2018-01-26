namespace TYT.Portal.Models
{
    public interface IMediaFile
    {
        string Url { get; set; }
        string Length { get; set; }
        string Type { get; set; }
    }
}
