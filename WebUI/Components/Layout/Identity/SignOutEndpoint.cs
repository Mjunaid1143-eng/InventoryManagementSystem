using Application.Extension.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace WebUI.Components.Layout.Identity
{
    internal static class SignOutEndpoint
    {
        public static IEndpointConventionBuilder MapSignOutEndpoint(this IEndpointRouteBuilder endpoint)
        {
            ArgumentNullException.ThrowIfNull(endpoint);
            var accountGroup = endpoint.MapGroup("/Account");
            accountGroup.MapPost("/Logout", async (ClaimsPrincipal user, SignInManager<ApplicationUser> SignInManager) =>
            {
                await SignInManager.SignOutAsync();
                return TypedResults.LocalRedirect("/Account/Login");
            });

            return accountGroup;
        }
    }
}
