namespace PetCare.Api.Controllers
{
    using CreateOwner;
    using GetOwner;

    [ApiController]
    [EnableCors("PetCare-FE")]
    [Route("api/[controller]/[action]")]
    public class AuthenticationController : BaseController<DoctorController>
    {
        [HttpPost]
        [ModelValidationFilter]
        [ActionName(nameof(Register))]
        public async Task<ActionResult<Owner>> Register(CreateOwnerDto registerRequest)
        {
            ComparePasswords comparePasswordsCommand = new ComparePasswords() 
            {
                Password = registerRequest.Password,
                ConfirmPassword = registerRequest.ConfirmPassword,
            };

            bool comparePasswordsResult = await base.Mediator.Send(comparePasswordsCommand);

            if (!comparePasswordsResult) BadRequest();

            CreatePasswordHash createPasswordHashCommand = new() { Password = registerRequest.Password };
            ComputedPassword computedPassowrd = await base.Mediator.Send(createPasswordHashCommand);
            CreateOwner createOwnerCommand = base.Mapper.Map<CreateOwner>(registerRequest);
            createOwnerCommand.PasswordHash = computedPassowrd.PasswordHash;
            createOwnerCommand.PasswordSalt = computedPassowrd.PasswordSalt;
            Owner owner = await base.Mediator.Send(createOwnerCommand);
            GetOwnerDto getOwnerDto = base.Mapper.Map<GetOwnerDto>(owner);
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<string>> Login(UserLoginDto loginRequest)
        {
            GetOwnerByUsername getOwnerCommand = new() { Username = loginRequest.Username };
            Owner owner = await base.Mediator.Send(getOwnerCommand);
            VerifyPasswordHash verifyPasswordCommand = new() 
            {
                Password = loginRequest.Password,
                PasswordHash = owner.PasswordHash!,
                PasswordSalt = owner.PasswordSalt!,
            };

            bool verification = await base.Mediator.Send(verifyPasswordCommand);

            if (!verification)
            {
                return BadRequest("Wrong password");
            }

            GenerateToken generateTokenCommand = new() { Owner = owner };
            JwtToken ownerToken = await this.Mediator.Send(generateTokenCommand);
            ownerToken.Username = owner.Username!;
            ownerToken.UserId = owner.Id;
            ownerToken.ProfileImageFilePath = owner.ProfileImageFilePath;

            return Ok(ownerToken);
        }
    }
}
