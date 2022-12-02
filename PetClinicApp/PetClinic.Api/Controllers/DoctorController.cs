namespace PetClinic.Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using PetClinic.Api.Dtos;
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
            var query = new GetAllDoctors();
            var result = await Madiator.Send(query);
            var mappedResult = Mapper.Map<List<GetDoctorDto>>(result);
            return Ok(mappedResult);
        }
    }
}
