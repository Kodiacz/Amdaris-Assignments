namespace PetCare.Api.Controllers
{
    using GetPet;
    using CreatePet;
    using UpdatePet;
    using DeletePet;
    using UpdatePartialPet;

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PetController : BaseController<PetController>
    {
        [HttpGet]
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
        public async Task<IActionResult> GetById(int petId)
        {
            GetPetById query = new() { Id = petId };
            Pet petEntity = await base.Mediator.Send(query);
            GetPetDto getPetDto = base.Mapper.Map<GetPetDto>(petEntity);
            return Ok(getPetDto);
        }

        [HttpPost]
        [ModelValidationFilter]
        [ActionName(nameof(Create))]
        public async Task<IActionResult> Create([FromBody] CreatePetDto createPetDto)
        {
            CreatePet command = base.Mapper.Map<CreatePet>(createPetDto);
            Pet newPetEntity = await base.Mediator.Send(command);
            GetPetDto getPetDto = base.Mapper.Map<GetPetDto>(newPetEntity);
            return CreatedAtAction(nameof(GetById), new { petId = newPetEntity.Id }, getPetDto);
        }

        [HttpPut]
        [Route("{petId}")]
        [ModelValidationFilter]
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
        [ActionName(nameof(PartialUpdate))]
        public async Task<IActionResult> PartialUpdate(JsonPatchDocument<UpdatePetDto> jsonPatchDocument, int petId)
        {
            GetPetByIdAsReadonly query = new() { Id = petId };
            Pet doctorForUpdate = await base.Mediator.Send(query);

            UpdatePetDto updatePetDto = base.Mapper.Map<UpdatePetDto>(doctorForUpdate);

            jsonPatchDocument.ApplyTo(updatePetDto, ModelState);

            if (!TryValidateModel(updatePetDto))
            {
                return BadRequest();
            }

            PartialUpdatePet command = base.Mapper.Map<PartialUpdatePet>(updatePetDto);
            command.Id = petId;

            doctorForUpdate = await base.Mediator.Send(command);

            return NoContent();
        }

        [HttpDelete]
        [Route("petId")]
        [ActionName(nameof(Delete))]
        public async Task<IActionResult> Delete(int petId)
        {
            DeleteSoft command = new() { Id = petId };
            Pet deletedPetEntity = await base.Mediator.Send(command);
            return NoContent();
        }
    }
}
