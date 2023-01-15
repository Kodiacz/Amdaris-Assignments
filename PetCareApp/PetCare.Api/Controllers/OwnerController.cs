namespace PetCare.Api.Controllers
{
    using GetOwner;
    using CreateOwner;
    using UpdateOwner;
    using DeleteOwner;
    using PartialUpdateOwner;
using static PetCare.Api.Controllers.FileUploadController;

    [ApiController]
    [EnableCors("PetCare-FE")]
    [Route("api/[controller]/[action]")]
    public class OwnerController : BaseController<OwnerController>
    {
        /// <summary>
        /// Gets all owners from the database
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ActionName(nameof(GetAll))]
        public async Task<IActionResult> GetAll()
        {
            GetAllOwners command = new GetAllOwners();
            List<Owner> owners = await base.Mediator.Send(command);
            List<GetOwnerDto> ownersDto = base.Mapper.Map<List<GetOwnerDto>>(owners);
            return Ok(ownersDto);
        }

        [HttpGet]
        [Route("{ownerId}")]
        [ActionName(nameof(GetAllOwnerPets))]
        public async Task<IActionResult> GetAllOwnerPets(int ownerId)
        {
            GetAllOwnerPets command = new() { OwnerId = ownerId };
            List<Pet> petEntities = await base.Mediator.Send(command);
            List<GetPetDto> getPetDtos = base.Mapper.Map<List<GetPetDto>>(petEntities);
            return Ok(getPetDtos);
        }

        /// <summary>
        /// Gets a spasific owner with his ID
        /// </summary>
        /// <param name="ownerId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{ownerId}")]
        [ActionName(nameof(GetById))]
        public async Task<IActionResult> GetById(int ownerId)
        {
            GetOwnerById command = new GetOwnerById() { Id = ownerId, };
            Owner owner = await base.Mediator.Send(command);
            GetOwnerDto getOwnerDto = base.Mapper.Map<GetOwnerDto>(owner);
            return Ok(getOwnerDto);
        }

        /// <summary>
        /// Creates a owner and adds it in the database
        /// </summary>
        /// <param name="createOwnerDto"></param>
        /// <returns>returns a dto created from the owner</returns>
        [HttpPost]
        [ModelValidationFilter]
        [ActionName(nameof(Create))]
        public async Task<IActionResult> Create([FromBody] CreateOwnerDto createOwnerDto)
        {
            CreateOwner command = base.Mapper.Map<CreateOwner>(createOwnerDto);
            Owner owner = await base.Mediator.Send(command);
            GetOwnerDto getOwnerDto = base.Mapper.Map<GetOwnerDto>(owner);
            return CreatedAtAction(nameof(GetById), new { ownerId = owner.Id }, getOwnerDto);
        }

        /// <summary>
        /// Updates the doctor and applies the changes in the database 
        /// </summary>
        /// <param name="updateOwnerDto"></param>
        /// <param name="ownerId"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{ownerId}")]
        [ModelValidationFilter]
        [ActionName(nameof(Update))]
        public async Task<IActionResult> Update([FromBody] UpdateOwnerDto updateOwnerDto, int ownerId)
        {
            UpdateOwner command = this.Mapper.Map<UpdateOwner>(updateOwnerDto);
            command.Id = ownerId;
            Owner owner = await base.Mediator.Send(command);
            return NoContent();
        }

        [HttpPatch]
        [Route("{ownerId}")]
        [ModelValidationFilter]
        [ActionName(nameof(PartialUpdate))]
        public async Task<IActionResult> PartialUpdate(JsonPatchDocument<UpdateOwnerDto> jsonPatchDocument, int ownerId)
        {
            GetOwnerByIdAsReadonly query = new() { Id = ownerId };
            Owner doctorForUpdate = await base.Mediator.Send(query);

            UpdateOwnerDto updateOwnerDto = base.Mapper.Map<UpdateOwnerDto>(doctorForUpdate);

            jsonPatchDocument.ApplyTo(updateOwnerDto, ModelState);

            PartialUpdateOwner command = base.Mapper.Map<PartialUpdateOwner>(updateOwnerDto);
            command.Id = ownerId;

            if (!TryValidateModel(updateOwnerDto))
            {
                return BadRequest();
            }

            doctorForUpdate = await base.Mediator.Send(command);

            return NoContent();
        }

        /// <summary>
        /// Marks the entity as deleted but it doesn't really 
        /// removes it from the database 
        /// </summary>
        /// <param name="ownerId"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{ownerId}")]
        [ActionName(nameof(Delete))]
        public async Task<IActionResult> Delete(int ownerId)
        {
            DeleteSoft command = new() { Id = ownerId };
            Owner owner = await base.Mediator.Send(command);
            return NoContent();
        }

        /// <summary>
        /// Uploads file to folder
        /// </summary>
        /// <param name="fileUpload">contains the File to be upload</param>
        /// <param name="specificFolder">It is an optional parametar. Continuation of the path</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> UploadOwnerProfilePicture([FromForm] FileUpload fileUpload)
        {
            if (!Directory.Exists(UserProfilePicturesFolderPath))
            {
                Directory.CreateDirectory(UserProfilePicturesFolderPath);
            }

            using (FileStream fileStram = System.IO.File.Create(UserProfilePicturesFolderPath + fileUpload.File.FileName))
            {
                fileUpload.File.CopyTo(fileStram);
                fileStram.Flush();
                return Ok();
            }
        }
    }
}
