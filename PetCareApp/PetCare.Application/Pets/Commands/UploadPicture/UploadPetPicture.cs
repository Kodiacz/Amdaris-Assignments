namespace PetCare.Application.Pets.Commands.UploadPicture
{
    public class UploadPetPicture : IRequest<string>
    {
        public string FolderPath { get; set; } = null!;

        public string FileName { get; set; } = null!;
    }
}
