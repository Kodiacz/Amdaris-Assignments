namespace PetCare.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileUploadController : BaseController<FileUploadController>
    {
        /// <summary>
        /// Uploads file to folder
        /// </summary>
        /// <param name="fileUpload">contains the File to be upload</param>
        /// <param name="specificFolder">It is an optional parametar. Continuation of the path</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Upload([FromForm] FileUpload fileUpload, string? specificFolder)
        {
            string path = specificFolder == null ?
                ImagesFolderPath :
                ImagesFolderPath + specificFolder + @"\";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            using (FileStream fileStram = System.IO.File.Create(path + fileUpload.File.FileName))
            {
                fileUpload.File.CopyTo(fileStram);
                fileStram.Flush();
                return Ok();
            }
        }

        /// <summary>
        /// Gets a file from the spasific folder
        /// </summary>
        /// <param name="fileName">Contains the name of the file to be returned</param>
        /// <param name="specificFolder">It is an optional parametar. Continuation of the path</param>
        /// <returns>The file that is being requested from the client</returns>
        [HttpGet]
        [Route("{fileName}")]

        public async Task<IActionResult> TestGet(string fileName, string? specificFolder)
        {
            string path = specificFolder == null ?
                ImagesFolderPath :
                ImagesFolderPath + specificFolder + @"\";

            var filePath = path + fileName + ".jpg";

            byte[] b = System.IO.File.ReadAllBytes(filePath);
            return File(b, "image/png");
        }


        public class FileUpload
        {
            public IFormFile File { get; set; } = null!;
        }
    }
}
