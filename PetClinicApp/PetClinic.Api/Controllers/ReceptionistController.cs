namespace PetClinic.Api.Controllers
{
    using GetReceptionist;
    using CreateReceptionist;
    using UpdateReceptionist;
    using DeleteReceptionist;


    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReceptionistController : BaseController<ReceptionistController>
    {
        [HttpGet]
        [ActionName(nameof(GetAll))]
        public async Task<IActionResult> GetAll()
{
            GetAllReceptionists query = new();
            List<Receptionist> receptionist = await base.Mediator.Send(query);

            if (receptionist == null)
            {
                return NotFound();
            }

            List<GetReceptionistDto> getReceptionistDto = base.Mapper.Map<List<GetReceptionistDto>>(receptionist);
            return Ok(receptionist);
        }


        [HttpGet]
        [Route("{receptinistId}")]
        [ActionName(nameof(GetById))]
        public async Task<IActionResult> GetById(int receptionistId)
        {
            GetByIdReceptionist query = new() { Id = receptionistId };
            Receptionist receptionist = await base.Mediator.Send(query);

            if (receptionist == null)
            {
                return NotFound();
            }

            GetReceptionistDto getReceptionistDto = base.Mapper.Map<GetReceptionistDto>(receptionist);
            return Ok(receptionist);
        }

        [HttpPost]
        [ActionName(nameof(Create))]
        public async Task<IActionResult> Create([FromBody] CreateReceptionistDto createReceptionistDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            CreateReceptionist command = base.Mapper.Map<CreateReceptionist>(createReceptionistDto);

            Receptionist createdReceptionistEntity = await base.Mediator.Send(command);
            GetReceptionistDto getReceptionistDto = base.Mapper.Map<GetReceptionistDto>(createdReceptionistEntity);
            return CreatedAtAction(nameof(GetById), new { receptionistId = createdReceptionistEntity.Id }, getReceptionistDto);
        }

        [HttpPut]
        [Route("{receptionistId}")]
        [ActionName(nameof(Update))]
        public async Task<IActionResult> Update([FromBody] UpdateReceptionistDto updateReceptionistDto, int receptionistId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            UpdateReceptionist command = base.Mapper.Map<UpdateReceptionist>(updateReceptionistDto);
            command.Id = receptionistId;

            Receptionist updatedReceptionistEntity = await base.Mediator.Send(command);

            if (updatedReceptionistEntity == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete]
        [Route("{receptionistId}")]
        [ActionName(nameof(Delete))]
        public async Task<IActionResult> Delete(int receptionistId)
        {
            DeleteSoft command = new() { Id = receptionistId };

            try
            {
                Receptionist deletedReceptionistEntity = await base.Mediator.Send(command);

                return NoContent();
            }
            catch (AlreadyDeletedException)
            {

                return BadRequest($"the Receptionist with ID {receptionistId} is already deleted");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
