using Microsoft.AspNetCore.Diagnostics;


namespace API.Middleware;

public class AppExceptionHandler : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
    {
        var response = new ErrorResponse()
        {
            StatusCode = StatusCodes.Status500InternalServerError,
            ExceptionMessage = exception.Message,
            Title = "Something went wrong"
        };

        await httpContext.Response.WriteAsJsonAsync(response, cancellationToken);
        httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;

        return true;
    }
}

internal class ErrorResponse
{
    public ErrorResponse()
    {
    }

    public int StatusCode { get; set; }
    public string ExceptionMessage { get; set; }
    public string Title { get; set; }
}
