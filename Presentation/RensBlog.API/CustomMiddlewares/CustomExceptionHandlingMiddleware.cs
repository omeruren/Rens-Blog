using FluentValidation;
using RensBlog.Application.Base;

namespace RensBlog.API.CustomMiddlewares
{
    public class CustomExceptionHandlingMiddleware(RequestDelegate next)
    {

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (ValidationException e)
            {

                context.Response.StatusCode = StatusCodes.Status400BadRequest;
                context.Response.ContentType = "application/json";

                var response = new BaseResult<object>()
                {
                    Errors = e.Errors.GroupBy(x => x.PropertyName).Select(group => new Dictionary<string, string>
                    {
                        {
                            group.Key,
                            group.Select(x=>x.ErrorMessage).FirstOrDefault()
                        }
                    }).ToList()
                };

                await context.Response.WriteAsJsonAsync(response);
            }
            catch (Exception e)
            {
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                await context.Response.WriteAsJsonAsync(new { errorMessage = "An unexpected error occured : " + e.Message });
            }
        }



    }
}
