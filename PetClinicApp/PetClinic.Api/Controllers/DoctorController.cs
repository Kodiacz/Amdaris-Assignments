namespace PetClinic.Api.Controllers
{
    using GetDoctor;
    using CreateDoctor;
    using UpdateDoctor;
    using DeleteDoctor;

    [Route("api/[controller]/[action]")]
    [ApiController]
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
            GetDoctorById query = new GetDoctorById()
            {
                Id = doctorId,
            };

            Doctor result = await base.Mediator.Send(query);

            if (result == null)
            {
                return NotFound();
            }

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
        [ActionName(nameof(Update))]
        [Route("{doctorId}")]
        [ModelValidationFilter]
        public async Task<IActionResult> Update([FromBody] UpdateDoctorDto updateDoctorDto, int doctorId)
        {
            UpdateDoctor command = base.Mapper.Map<UpdateDoctor>(updateDoctorDto);

            command.Id = doctorId;

            Doctor result = await base.Mediator.Send(command);

            if (result == null)
            {
                return NotFound();
            }

            return NoContent();
        }

        /// <summary>
        /// Marks the entity as deleted but it doesn't really 
        /// removes it from the database 
        /// </summary>
        /// <param name="doctorId"></param>
        /// <returns></returns>
        [HttpDelete]
        [ActionName(nameof(Delete))]
        [Route("doctorId")]
        public async Task<IActionResult> Delete(int doctorId)
        {
            DeleteSoft command = new DeleteSoft()
            {
                Id = doctorId
            };

                Doctor result = await base.Mediator.Send(command);

                if (result == null)
                {
                    return NotFound();
                }

                return NoContent();
        }
    }
}
