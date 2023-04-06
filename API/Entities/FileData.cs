namespace API.Entities;

public class FileData
{
    public int FileId { get; set; }
    public string FileName { get; set; }
    public string FilePath { get; set; }
    public string FileExtension { get; set; }
    public string MimeType { get; set; }
}