namespace PetClinic.Api.Controllers
{
    [Route("api/owner")]
    [ApiController]
    public class OwnerController : BaseController<OwnerController>
    {
        [HttpGet]
        [Route("/GetAllOwners")]
        public async Task<IActionResult> GetAllOwners()
        {
            GetAllOwners command = new GetAllOwners();
            List<Owner> owners = await base.Madiator.Send(command);
            List<GetOwnerDto> ownersDto = base.Mapper.Map<List<GetOwnerDto>>(owners);
            return Ok(ownersDto);
        }
    }
}
