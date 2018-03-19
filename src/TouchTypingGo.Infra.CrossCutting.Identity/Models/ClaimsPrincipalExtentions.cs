using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace TouchTypingGo.Infra.CrossCutting.Identity.Models
{
    public static class ClaimsPrincipalExtentions
    {
        public static string GetUserId(this ClaimsPrincipal principal)
        {
            if (principal == null)
            {
                throw new ArgumentException(nameof(principal));
            }
            var claim = principal.FindFirst(ClaimTypes.NameIdentifier);
            return claim?.Value;
        }
    }
}
