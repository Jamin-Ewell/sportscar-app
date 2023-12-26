using Microsoft.AspNetCore.Identity;
using sportscar_app.Application.Common.Models;

namespace sportscar_app.Infrastructure.Identity;
public static class IdentityResultExtensions
{
    public static Result ToApplicationResult(this IdentityResult result)
    {
        return result.Succeeded
            ? Result.Success()
            : Result.Failure(result.Errors.Select(e => e.Description));
    }
}
