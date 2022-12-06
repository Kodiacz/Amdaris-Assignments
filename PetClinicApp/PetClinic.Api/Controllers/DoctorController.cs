namespace PetClinic.Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using PetClinic.Domain.Entities;
    using PetClinic.Api.Dtos.DoctorDtos;
    using PetClinic.Doctors.Commands.Create;
    using PetClinic.Application.Doctors.Queries.Get;
    using PetClinic.Application.Doctors.Commands.Update;

    [Route("api/doctor")]
    [ApiController]
    public class DoctorController : BaseController<DoctorController>
    {
        /// <summary>
        /// Gets all doctors from the database
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/getAll")]
        public async Task<IActionResult> GetAll()
        {
            GetAllDoctors query = new GetAllDoctors();
            List<Doctor> result = await base.Madiator.Send(query);
            List<GetDoctorDto> mappedResult = base.Mapper.Map<List<GetDoctorDto>>(result);
            return Ok(mappedResult);
        }

        [HttpGet]
        [Route("/getById/{doctorId}")]
        public async Task<IActionResult> GetById(int doctorId)
        {
            GetDoctorById query = new GetDoctorById()
            {
                Id = doctorId,
            };

            Doctor result = await base.Madiator.Send(query);

            if (result == null)
            {
                return NotFound();
            }

            GetDoctorDto getDoctorDto = base.Mapper.Map<GetDoctorDto>(result);
            return Ok(getDoctorDto);
        }

        [HttpPost]
        [Route("/create")]
        public async Task<IActionResult> Create([FromBody] CreateDoctorDto createDoctorDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            CreateDoctor command = base.Mapper.Map<CreateDoctor>(createDoctorDto);
            Doctor result = await base.Madiator.Send(command);
            GetDoctorDto getDoctorDto = base.Mapper.Map<GetDoctorDto>(result);
            return CreatedAtAction(nameof(GetById), new { doctorId = result.Id }, getDoctorDto);
        }

        [HttpPost]
        [Route("/update/{doctorId}")]
        public async Task<IActionResult> Update([FromBody] UpdateDoctorDto updateDoctorDto, int doctorId)
        {
            UpdateDoctor command = base.Mapper.Map<UpdateDoctor>(updateDoctorDto);

            command.Id = doctorId;

            Doctor result = await base.Madiator.Send(command);

            if (result == null)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
