namespace PetCare.Application.Pets.Commands.UploadPicture
{
    public class UploadPetPictureHandler : IRequestHandler<UploadPetPicture, string>
    {
        private readonly IUnitOfWork repo;

        public UploadPetPictureHandler(IUnitOfWork repo)
        {
            this.repo = repo;
        }

        public Task<string> Handle(UploadPetPicture request, CancellationToken cancellationToken)
        {
            //if (!Directory.Exists(request.FolderPath))
            //{
            //    Directory.CreateDirectory(request.FolderPath);
            //}

            //using (FileStream fileStram = System.IO.File.Create(request.FolderPath + request.FileName))
            //{
            //    fileUpload.File.CopyTo(fileStram);
            //    fileStram.Flush();
            //    return Ok();
            //}

            return null;
        }
    }
}
