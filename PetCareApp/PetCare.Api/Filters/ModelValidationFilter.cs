namespace PetCare.Api.Filters
{
    public class ModelValidationFilterAttribute : Attribute, IAsyncActionFilter
    {

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {

            if (!context.ModelState.IsValid)
            {
                context.Result = new BadRequestResult();
            }

            await next();
        }
    }
}
