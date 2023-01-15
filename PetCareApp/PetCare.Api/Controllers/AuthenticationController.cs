namespace PetCare.Api.Controllers
{
    using CreateOwner;

    [ApiController]
    [EnableCors("PetCare-FE")]
    [Route("api/[controller]/[action]")]
    public class AuthenticationController : BaseController<DoctorController>
    {
        [HttpPost]
        [ModelValidationFilter]
        [ActionName(nameof(Register))]
        public async Task<ActionResult<Owner>> Register(CreateOwnerDto request)
        {
            CreatePasswordHash createPasswordHashCommand = new() { Password = request.Password };
            ComputedPassword computedPassowrd = await base.Mediator.Send(createPasswordHashCommand);
            CreateOwner createOwnerCommand = base.Mapper.Map<CreateOwner>(request);
            createOwnerCommand.PasswordHash = computedPassowrd.PasswordHash;
            createOwnerCommand.PasswordSalt = computedPassowrd.PasswordSalt;
            Owner owner = await base.Mediator.Send(createOwnerCommand);
            return Ok(owner);
        }

        //private void CreatePasswordHash(string password, out byte[] PasswordHash, out byte[] PasswordSalt)
        //{
        //    using (var hmac = new HMACSHA512())
        //    {
        //        PasswordSalt = hmac.Key;
        //        PasswordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        //    }
        //}
    }
}
