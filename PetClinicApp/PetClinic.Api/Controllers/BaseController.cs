namespace PetClinic.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T> : ControllerBase where T : BaseController<T>
    {
        private ILogger<T>? logger;
        private IMapper? mapper;
        private IMediator? mediator;

        protected ILogger<T> Logger => logger ??= HttpContext.RequestServices.GetRequiredService<ILogger<T>>();

        protected IMapper Mapper => mapper ??= HttpContext.RequestServices.GetRequiredService<IMapper>();

        protected IMediator Madiator => mediator ??= HttpContext.RequestServices.GetRequiredService<IMediator>();
    }
}
