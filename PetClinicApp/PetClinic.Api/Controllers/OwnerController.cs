namespace PetClinic.Api.Controllers
{
    using GetOwner;
    using CreateOwner;
    using UpdateOwner;
    using DeleteOwner;

    [Route("api/[controller]/[action]")]
    [ApiController]
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

            if (owner == null)
            {
                return NotFound();
            }

            GetOwnerDto getOwnerDto = base.Mapper.Map<GetOwnerDto>(owner);

            return Ok(getOwnerDto);
        }

        /// <summary>
        /// Creates a owner and adds it in the database
        /// </summary>
        /// <param name="createOwnerDto"></param>
        /// <returns>returns a dto created from the owner</returns>
        [HttpPost]
        [ActionName(nameof(Create))]
        public async Task<IActionResult> Create([FromBody] CreateOwnerDto createOwnerDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            CreateOwner command = base.Mapper.Map<CreateOwner>(createOwnerDto);
            Owner owner = await base.Mediator.Send(command);
            GetOwnerDto getOwnerDto = base.Mapper.Map<GetOwnerDto>(owner);
            return CreatedAtAction(nameof(GetById), new { ownerId = owner.Id }, getOwnerDto);
        }

        /// <summary>
        /// Updates the doctor and applies the changes in the database 
        /// </summary>
        /// <param name="updateDoctorDto"></param>
        /// <param name="doctorId"></param>
        /// <returns></returns>
        [HttpPut]
        [ActionName(nameof(Update))]
        [Route("{ownerId}")]
        public async Task<IActionResult> Update([FromBody] UpdateOwnerDto updateOwnerDto, int ownerId)
        {
            if (ModelState.IsValid!)
            {
                return BadRequest(ModelState);
            }

            UpdateOwner command = this.Mapper.Map<UpdateOwner>(updateOwnerDto);
            command.Id = ownerId;

            Owner owner = await base.Mediator.Send(command);

            if (owner == null)
            {
                return NoContent();
            }
            
            return NoContent();
        }

        /// <summary>
        /// Marks the entity as deleted but it doesn't really 
        /// removes it from the database 
        /// </summary>
        /// <param name="ownerId"></param>
        /// <returns></returns>
        [HttpDelete]
        [ActionName(nameof(Delete))]
        [Route("{ownerId}")]
        public async Task<IActionResult> Delete(int ownerId)
        {
            DeleteSoft command = new() { Id = ownerId };

            try
            {
                Owner owner = await base.Mediator.Send(command);

                if (owner == null)
                {
                    return NoContent();
                }

                return NoContent();
            }
            catch (AlreadyDeletedException)
            {
                return BadRequest($"The Owner with ID {ownerId} is Already Deleted");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
