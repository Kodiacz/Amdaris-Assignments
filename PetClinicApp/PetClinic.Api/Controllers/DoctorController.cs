namespace PetClinic.Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using PetClinic.Api.Dtos;
    using PetClinic.Domain.Entities;
    using PetClinic.Application.Doctors.Queries.Get;

    [Route("api/doctor")]
    [ApiController]
    public class DoctorController : BaseController<DoctorController>
    {
        /// <summary>
        /// Gets all doctors from the database
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetDoctors()
        {
            GetAllDoctors query = new GetAllDoctors();
            List<Doctor> result = await Madiator.Send(query);
            List<GetDoctorDto> mappedResult = Mapper.Map<List<GetDoctorDto>>(result);
            return Ok(mappedResult);
        }
    }
}
