namespace PetCare.Api.Models
{
    public class FileUpload
    {
        public IFormFile File { get; set; } = null!;

        public int EntityId { get; set; }
    }
}
