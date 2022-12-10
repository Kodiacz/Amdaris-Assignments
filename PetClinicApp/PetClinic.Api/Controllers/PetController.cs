namespace PetClinic.Api.Controllers
{
    using GetPet;
    using CreatePet;
    using UpdatePet;
    using DeletePet;


    [Route("api/[controller]")]
    [ApiController]
    public class PetController : BaseController<PetController>
    {
        [HttpGet]
        [ActionName("GetAllPets")]
        public async Task<IActionResult> GetAll()
        {
            GetAllPets query = new();
            List<Pet> pets = await base.Mediator.Send(query);
            List<GetPetDto> petsDtos = base.Mapper.Map<List<GetPetDto>>(pets);
            return Ok(petsDtos);
        }

        public async Task<IActionResult> GetById(int petId)
        {
            GetPetById query = new() { Id = petId };
            Pet petEntity = await base.Mediator.Send(query);
        }
    }
}
