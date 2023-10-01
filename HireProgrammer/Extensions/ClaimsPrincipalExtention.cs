using HireProgrammer.Core.Constants;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace HireProgrammer.Extensions
{
    public static class ClaimsPrincipalExtension
    {
        public static string Id(this ClaimsPrincipal user)
        {
            return user.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
