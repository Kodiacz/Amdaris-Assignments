namespace PetCare.Api.Filters
{
    public class ExceptionHandler : IExceptionFilter
    {
        private readonly ILogger<ExceptionHandler> logger;

        public ExceptionHandler(ILogger<ExceptionHandler> logger)
        {
            this.logger = logger;
        }

        public void OnException(ExceptionContext context)
        {
            logger.LogError(context.Exception.Message);

            ProblemDetails problemDeitals = new()
            {
                Title = context.Exception.Message,
                Status = GetStatusCode(context),
                Detail = context.Exception.InnerException?.Message,
            };

            context.Result = new ObjectResult(problemDeitals);

            context.ExceptionHandled = true;
        }

        private int GetStatusCode(ExceptionContext context)
        {
            switch (context.Exception)
            {
                case AlreadyDeletedException:
                    return (int)HttpStatusCode.MethodNotAllowed;
                case ArgumentNullException:
                    return (int)HttpStatusCode.NotFound;
                default:
                    return (int)HttpStatusCode.InternalServerError;
            }
        }
    }
}
