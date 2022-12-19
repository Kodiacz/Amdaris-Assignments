namespace PetClinic.Api.Controllers
{
    using GetPet;
    using CreatePet;
    using UpdatePet;
    using DeletePet;


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
        [ActionName(nameof(GetById))]
        [Route("{petId}")]
        public async Task<IActionResult> GetById(int petId)
        {
            GetPetById query = new() { Id = petId };
            Pet petEntity = await base.Mediator.Send(query);

            if (petEntity == null)
            {
                return NotFound();
            }

            GetPetDto getPetDto = base.Mapper.Map<GetPetDto>(petEntity);

            return Ok(getPetDto);
        }

        [HttpPost]
        [ActionName(nameof(Create))]
        [ModelValidationFilter]
        public async Task<IActionResult> Create([FromBody] CreatePetDto createPetDto)
        {
            CreatePet command = base.Mapper.Map<CreatePet>(createPetDto);

            Pet newPetEntity = await base.Mediator.Send(command);
            GetPetDto getPetDto = base.Mapper.Map<GetPetDto>(newPetEntity);
            return CreatedAtAction(nameof(GetById), new { petId = newPetEntity.Id }, getPetDto);
        }

        [HttpPut]
        [ActionName(nameof(Update))]
        [Route("{petId}")]
        [ModelValidationFilter]
        public async Task<IActionResult> Update([FromBody] UpdatePetDto updatePetDto, int petId)
        {
            UpdatePet command = base.Mapper.Map<UpdatePet>(updatePetDto);
            command.Id = petId;

            Pet updatedPetEntity = await base.Mediator.Send(command);

            if (updatedPetEntity == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete]
        [ActionName(nameof(Delete))]
        [Route("petId")]
        public async Task<IActionResult> Delete(int petId)
        {
            DeleteSoft command = new() { Id = petId };

            Pet deletedPetEntity = await base.Mediator.Send(command);

            return NoContent();
        }
    }
}
