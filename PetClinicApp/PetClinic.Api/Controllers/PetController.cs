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
        [ActionName("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            GetAllPets query = new();
            List<Pet> pets = await base.Mediator.Send(query);
            List<GetPetDto> petsDtos = base.Mapper.Map<List<GetPetDto>>(pets);
            return Ok(petsDtos);
        }

        [HttpGet]
        [ActionName("GetById")]
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
        [ActionName("Create")]
        public async Task<IActionResult> Create([FromBody] CreatePetDto createPetDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            CreatePet command = base.Mapper.Map<CreatePet>(createPetDto);

            try
            {
                Pet newPetEntity = await base.Mediator.Send(command);
                GetPetDto getPetDto = base.Mapper.Map<GetPetDto>(newPetEntity);
                return CreatedAtAction(nameof(GetById), new { petId = newPetEntity.Id }, getPetDto);
            }
            catch (NotExistException)
            {
                return BadRequest($"the Owner with this Id {createPetDto.OwnerId} of this pet does not exist in the database");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [ActionName("Update")]
        [Route("{petId}")]
        public async Task<IActionResult> Update([FromBody] UpdatePetDto updatePetDto, int petId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

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
        [ActionName("Delete")]
        [Route("petId")]
        public async Task<IActionResult> Delete(int petId)
        {
            DeleteSoft command = new() { Id = petId };

            try
            {
                Pet deletedPetEntity = await base.Mediator.Send(command);

                return NoContent();
            }
            catch (AlreadyDeletedException)
            {
                return BadRequest($"Pet with this Id {petId} is already deleted");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
