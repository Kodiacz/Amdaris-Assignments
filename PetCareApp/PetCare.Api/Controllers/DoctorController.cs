namespace PetCare.Api.Controllers
{
    using GetDoctor;
    using CreateDoctor;
    using UpdateDoctor;
    using DeleteDoctor;
    using UpdatePartialDoctor;

    [ApiController]
    [EnableCors("PetCare-FE")]
    [Route("api/[controller]/[action]")]
    public class DoctorController : BaseController<DoctorController>
    {
        /// <summary>
        /// Gets all doctors from the database
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ActionName(nameof(GetAll))]
        public async Task<IActionResult> GetAll()
        {
            GetAllDoctors query = new GetAllDoctors();
            List<Doctor> result = await base.Mediator.Send(query);
            List<GetDoctorDto> mappedResult = base.Mapper.Map<List<GetDoctorDto>>(result);
            return Ok(mappedResult);
        }

        /// <summary>
        /// Gets a spasific doctor with his ID
        /// </summary>
        /// <param name="doctorId"></param>
        /// <returns></returns>
        [HttpGet]
        [ActionName(nameof(GetById))]
        [Route("{doctorId}")]
        public async Task<IActionResult> GetById(int doctorId)
        {
            GetDoctorById query = new GetDoctorById() { Id = doctorId, };
            Doctor result = await base.Mediator.Send(query);
            GetDoctorDto getDoctorDto = base.Mapper.Map<GetDoctorDto>(result);
            return Ok(getDoctorDto);
        }

        /// <summary>
        /// Creates a doctor and adds it in the database
        /// </summary>
        /// <param name="createDoctorDto"></param>
        /// <returns></returns>
        [HttpPost]
        [ActionName(nameof(Create))]
        [ModelValidationFilter]
        public async Task<IActionResult> Create([FromBody] CreateDoctorDto createDoctorDto)
        {
            CreateDoctor command = base.Mapper.Map<CreateDoctor>(createDoctorDto);
            Doctor result = await base.Mediator.Send(command);
            GetDoctorDto getDoctorDto = base.Mapper.Map<GetDoctorDto>(result);
            return CreatedAtAction(nameof(GetById), new { doctorId = result.Id }, getDoctorDto);
        }

        /// <summary>
        /// Updates the doctor and applies the changes in the database 
        /// </summary>
        /// <param name="updateDoctorDto"></param>
        /// <param name="doctorId"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{doctorId}")]
        [ModelValidationFilter]
        public async Task<IActionResult> Update(UpdateDoctorDto updateDoctorDto, int doctorId)
        {
            UpdateDoctor command = base.Mapper.Map<UpdateDoctor>(updateDoctorDto);
            command.Id = doctorId;
            Doctor result = await base.Mediator.Send(command);
            return NoContent();
        }

        [HttpPatch]
        [Route("{doctorId}")]
        [ModelValidationFilter]
        public async Task<IActionResult> PartialUpdate(JsonPatchDocument<UpdateDoctorDto> jsonPatchDocument, int doctorId)
        {
            GetDoctorByIdAsReadonly query = new() { Id = doctorId };
            Doctor doctorForUpdate = await base.Mediator.Send(query);

            UpdateDoctorDto updateDoctorDto = base.Mapper.Map<UpdateDoctorDto>(doctorForUpdate);

            jsonPatchDocument.ApplyTo(updateDoctorDto, ModelState);

            PartialUpdateDoctor command = base.Mapper.Map<PartialUpdateDoctor>(updateDoctorDto);
            command.Id = doctorId;

            if (!TryValidateModel(updateDoctorDto))
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
        /// <param name="doctorId"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("doctorId")]
        [ActionName(nameof(Delete))]
        public async Task<IActionResult> Delete(int doctorId)
        {
            DeleteSoft command = new DeleteSoft() { Id = doctorId };
            Doctor doctor = await base.Mediator.Send(command);
            return NoContent();
        }
    }
}
