namespace PetCare.Api.Controllers
{
    using GetOwner;
    using CreateOwner;
    using CreateAppointments;
    using UpdateOwner;
    using DeleteOwner;
    using PartialUpdateOwner;

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
        [Authorize(Roles = "User, Admin")]
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
        [Authorize(Roles = "User, Admin")]
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
        [Authorize(Roles = "User, Admin")]
        [ActionName(nameof(GetById))]
        public async Task<IActionResult> GetById(int ownerId)
        {
            GetOwnerById command = new GetOwnerById() { Id = ownerId, };
            Owner owner = await base.Mediator.Send(command);
            GetOwnerDto getOwnerDto = base.Mapper.Map<GetOwnerDto>(owner);
            return Ok(getOwnerDto);
        }

        /// <summary>
        /// Gets all appointments for the owner
        /// </summary>
        /// <param name="ownerId">contains the Id of the owner</param>
        /// <returns></returns>
        [HttpGet]
        [Route("{ownerId}")]
        [Authorize(Roles = "User, Admin")]
        [ActionName(nameof(GetOwnerAppointments))]
        public async Task<IActionResult> GetOwnerAppointments(int ownerId)
        {
            GetAllOwnerAppointments getAllOwnerAppointmentsCommand = new() { OwnerId = ownerId };
            List<Appointment> appointments = await base.Mediator.Send(getAllOwnerAppointmentsCommand);
            List<GetAppointmentDto> appointmentDtos = base.Mapper.Map<List<GetAppointmentDto>>(appointments);
            return Ok(appointmentDtos);
        }

        /// <summary>
        /// Creates a owner and adds it in the database
        /// </summary>
        /// <param name="createOwnerDto"></param>
        /// <returns>returns a dto created from the owner</returns>
        [HttpPost]
        [ModelValidationFilter]
        [ActionName(nameof(Create))]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([FromBody] CreateOwnerDto createOwnerDto)
        {
            CreateOwner command = base.Mapper.Map<CreateOwner>(createOwnerDto);
            Owner owner = await base.Mediator.Send(command);
            GetOwnerDto getOwnerDto = base.Mapper.Map<GetOwnerDto>(owner);
            return CreatedAtAction(nameof(GetById), new { ownerId = owner.Id }, getOwnerDto);
        }

        /// <summary>
        /// Action method that creates and adds an Appointment in the database
        /// </summary>
        /// <param name="createAppointmentDto"></param>
        /// <returns></returns>
        [HttpPost]
        [ModelValidationFilter]
        [Authorize(Roles = "User, Admin")]
        [ActionName(nameof(AddAppointmentToOwnerById))]
        public async Task<IActionResult> AddAppointmentToOwnerById(CreateAppointmentDto createAppointmentDto)
        {
            CreateAppointmen createAppointmenCommand = base.Mapper.Map<CreateAppointmen>(createAppointmentDto);
            Appointment appointmen = await base.Mediator.Send(createAppointmenCommand);
            GetAppointmentDto getAppointmentDto = base.Mapper.Map<GetAppointmentDto>(appointmen);
            return Ok(getAppointmentDto);
        }

        /// <summary>
        /// Uploads a profile picture to the owner
        /// </summary>
        /// <param name="fileUpload"></param>
        /// <returns></returns>
        [HttpPost]
        [ActionName(nameof(UploadOwnerPicture))]
        [Authorize(Roles = "User, Admin")]
        public async Task<IActionResult> UploadOwnerPicture([FromForm] FileUpload fileUpload)
        {
            GetOwnerByIdAsReadonly query = new() { Id = fileUpload.EntityId };
            Owner ownerEntity = await base.Mediator.Send(query);
            UpdateOwner command = base.Mapper.Map<UpdateOwner>(ownerEntity);

            if (!Directory.Exists(PetPicturesFolderPath))
            {
                Directory.CreateDirectory(PetPicturesFolderPath);
            }

            command.ProfileImageFilePath = PetPicturesFolderPath + $"{command.ProfileImageFilePath}-" + fileUpload.File.FileName;

            using (FileStream fileStram = System.IO.File.Create(command.ProfileImageFilePath))
            {
                fileUpload.File.CopyTo(fileStram);
                fileStram.Flush();
                var updatedPet = await base.Mediator.Send(command);
                return Ok();
            }
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
        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "User")]
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
