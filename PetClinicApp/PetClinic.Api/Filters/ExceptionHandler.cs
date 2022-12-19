using System.Net;

namespace PetClinic.Api.Filters
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
            var exception = context.Exception;

            logger.LogError(context.Exception.Message);
            
            ProblemDetails problemDeitals = new()
            {
                Title = exception.Message,
                Status = (int)HttpStatusCode.InternalServerError,
            };

            context.Result = new ObjectResult(problemDeitals);

            context.ExceptionHandled = true;
        }
    }
}
