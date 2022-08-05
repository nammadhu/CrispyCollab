﻿using Common.Constants;
using System.Security.Claims;

namespace Common.Exstensions
{
    public static class ClaimsPrincipalExtensions
    {
        public static Guid GetUserIdAsGuid(this ClaimsPrincipal claimsPrincipal)
        {
            return new Guid(claimsPrincipal.FindFirst(ClaimConstants.UserIdClaimType).Value);
        }

        public static string GetUserIdAsString(this ClaimsPrincipal claimsPrincipal)
        {
            return claimsPrincipal.FindFirst(ClaimConstants.UserIdClaimType).Value;
        }

        public static Guid GetTenantIdAsGuid(this ClaimsPrincipal claimsPrincipal)
        {
            return new Guid(claimsPrincipal.FindFirst(ClaimConstants.TenantIdClaimType).Value);
        }

        public static string GetTenantIdAsString(this ClaimsPrincipal claimsPrincipal)
        {
            return claimsPrincipal.FindFirst(ClaimConstants.TenantIdClaimType).Value;
        }
    }
}
