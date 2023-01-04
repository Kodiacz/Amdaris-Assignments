namespace PetCare.Api.Controllers
{
    using GetReceptionist;
    using CreateReceptionist;
    using UpdateReceptionist;
    using DeleteReceptionist;
    using UpdatePartialReceptionist;

    [ApiController]
    [EnableCors("PetCare-FE")]
    [Route("api/[controller]/[action]")]
    public class ReceptionistController : BaseController<ReceptionistController>
    {
        [HttpGet]
        [ActionName(nameof(GetAll))]
        public async Task<IActionResult> GetAll()
        {
            GetAllReceptionists query = new();
            List<Receptionist> receptionist = await base.Mediator.Send(query);
            List<GetReceptionistDto> getReceptionistDto = base.Mapper.Map<List<GetReceptionistDto>>(receptionist);
            return Ok(receptionist);
        }


        [HttpGet]
        [Route("{receptinistId}")]
        [ActionName(nameof(GetById))]
        public async Task<IActionResult> GetById(int receptionistId)
        {
            GetReceptionistById query = new() { Id = receptionistId };
            Receptionist receptionist = await base.Mediator.Send(query);
            GetReceptionistDto getReceptionistDto = base.Mapper.Map<GetReceptionistDto>(receptionist);
            return Ok(receptionist);
        }

        [HttpPost]
        [ModelValidationFilter]
        [ActionName(nameof(Create))]
        public async Task<IActionResult> Create([FromBody] CreateReceptionistDto createReceptionistDto)
        {
            CreateReceptionist command = base.Mapper.Map<CreateReceptionist>(createReceptionistDto);

            Receptionist createdReceptionistEntity = await base.Mediator.Send(command);
            GetReceptionistDto getReceptionistDto = base.Mapper.Map<GetReceptionistDto>(createdReceptionistEntity);
            return CreatedAtAction(nameof(GetById), new { receptionistId = createdReceptionistEntity.Id }, getReceptionistDto);
        }

        [HttpPut]
        [Route("{receptionistId}")]
        [ActionName(nameof(Update))]
        [ModelValidationFilter]
        public async Task<IActionResult> Update([FromBody] UpdateReceptionistDto updateReceptionistDto, int receptionistId)
        {
            UpdateReceptionist command = base.Mapper.Map<UpdateReceptionist>(updateReceptionistDto);
            command.Id = receptionistId;
            Receptionist updatedReceptionistEntity = await base.Mediator.Send(command);
            return NoContent();
        }

        [HttpPatch]
        [Route("{receptionistId}")]
        [ModelValidationFilter]
        [ActionName(nameof(PartialUpdate))]
        public async Task<IActionResult> PartialUpdate(JsonPatchDocument<UpdateReceptionistDto> jsonPatchDocument, int receptionistId)
        {
            GetReceptionistByIdAsReadonly query = new() { Id = receptionistId };
            Receptionist doctorForUpdate = await base.Mediator.Send(query);

            UpdateReceptionistDto updateReceptionistDto = base.Mapper.Map<UpdateReceptionistDto>(doctorForUpdate);

            jsonPatchDocument.ApplyTo(updateReceptionistDto, ModelState);

            PartialUpdateReceptionist command = base.Mapper.Map<PartialUpdateReceptionist>(updateReceptionistDto);
            command.Id = receptionistId;

            if (!TryValidateModel(updateReceptionistDto))
            {
                return BadRequest();
            }

            doctorForUpdate = await base.Mediator.Send(command);

            return NoContent();
        }

        [HttpDelete]
        [Route("{receptionistId}")]
        [ActionName(nameof(Delete))]
        public async Task<IActionResult> Delete(int receptionistId)
        {
            DeleteSoft command = new() { Id = receptionistId };
            Receptionist deletedReceptionistEntity = await base.Mediator.Send(command);
            return NoContent();
        }
    }
}
