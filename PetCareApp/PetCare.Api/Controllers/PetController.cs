namespace PetCare.Api.Controllers
{
    using GetPet;
    using CreatePet;
    using UpdatePet;
    using DeletePet;
    using UpdatePartialPet;
using System.Data;
using PetCare.Api.Dtos.PetDtos;

    [ApiController]
    [EnableCors("PetCare-FE")]
    [Route("api/[controller]/[action]")]
    public class PetController : BaseController<PetController>
    {
        [HttpGet]
        [Authorize(Roles = "User, Admin")]
        [ActionName(nameof(GetAll))]
        public async Task<IActionResult> GetAll()
        {
            GetAllPets query = new();
            List<Pet> pets = await base.Mediator.Send(query);
            List<GetPetDto> petsDtos = base.Mapper.Map<List<GetPetDto>>(pets);
            return Ok(petsDtos);
        }

        [HttpGet]
        [Route("{petId}")]
        [ActionName(nameof(GetById))]
        [Authorize(Roles = "User, Admin")]
        public async Task<IActionResult> GetById(int petId)
        {
            GetPetById query = new() { Id = petId };
            Pet petEntity = await base.Mediator.Send(query);
            GetPetDto getPetDto = base.Mapper.Map<GetPetDto>(petEntity);
            return Ok(getPetDto);
        }

        [HttpPost]
        [ModelValidationFilter]
        [Authorize(Roles = "User, Admin")]
        [ActionName(nameof(Create))]
        public async Task<IActionResult> Create([FromBody] CreatePetDto createPetDto)
        {
            CreatePet command = base.Mapper.Map<CreatePet>(createPetDto);
            Pet newPetEntity = await base.Mediator.Send(command);
            GetPetDto getPetDto = base.Mapper.Map<GetPetDto>(newPetEntity);
            return CreatedAtAction(nameof(GetById), new { petId = newPetEntity.Id }, getPetDto);
        }

        /// <summary>
        /// Uploads file to folder
        /// </summary>
        /// <param name="fileUpload">contains the File to be upload</param>
        /// <param name="specificFolder">It is an optional parametar. Continuation of the path</param>
        /// <returns></returns>
        [HttpPost]
        [ActionName(nameof(UploadPetProfilePicture))]
        [Route("{petId}")]
        //[Authorize(Roles = "User, Admin")]
        public async Task<IActionResult> UploadPetProfilePicture([FromForm] FileUpload fileUpload, int petId)
        {
            GetPetByIdAsReadonly query = new() { Id = petId };
            Pet petEntity = await base.Mediator.Send(query);
            UpdatePet command = base.Mapper.Map<UpdatePet>(petEntity);

            if (!Directory.Exists(PetPicturesFolderPath))
            {
                Directory.CreateDirectory(PetPicturesFolderPath);
            }

            command.ImageFilePath = PetPicturesFolderPath + $"{command.Name}-" + fileUpload.File.FileName;

            using (FileStream fileStram = System.IO.File.Create(command.ImageFilePath))
            {
                fileUpload.File.CopyTo(fileStram);
                fileStram.Flush();
                var updatedPet = await base.Mediator.Send(command);
                return Ok();
            }
        }

        [HttpPut]
        [Route("{petId}")]
        [ModelValidationFilter]
        [Authorize(Roles = "User, Admin")]
        [ActionName(nameof(Update))]
        public async Task<IActionResult> Update([FromBody] UpdatePetDto updatePetDto, int petId)
        {
            UpdatePet command = base.Mapper.Map<UpdatePet>(updatePetDto);
            command.Id = petId;
            Pet updatedPetEntity = await base.Mediator.Send(command);
            return NoContent();
        }

        [HttpPatch]
        [Route("{petId}")]
        [ModelValidationFilter]
        [Authorize(Roles = "User, Admin")]
        [ActionName(nameof(PartialUpdate))]
        public async Task<IActionResult> PartialUpdate(JsonPatchDocument<UpdatePetDto> jsonPatchDocument, int petId)
        {
            GetPetByIdAsReadonly query = new() { Id = petId };
            Pet petForUpdate = await base.Mediator.Send(query);

            UpdatePetDto updatePetDto = base.Mapper.Map<UpdatePetDto>(petForUpdate);

            jsonPatchDocument.ApplyTo(updatePetDto, ModelState);

            if (!TryValidateModel(updatePetDto))
            {
                return BadRequest();
            }

            PartialUpdatePet command = base.Mapper.Map<PartialUpdatePet>(updatePetDto);
            command.Id = petId;

            petForUpdate = await base.Mediator.Send(command);

            return NoContent();
        }

        [HttpDelete]
        [Route("petId")]
        [Authorize(Roles = "User, Admin")]
        [ActionName(nameof(Delete))]
        public async Task<IActionResult> Delete(int petId)
        {
            DeleteSoft command = new() { Id = petId };
            Pet deletedPetEntity = await base.Mediator.Send(command);
            return NoContent();
        }
    }
}
