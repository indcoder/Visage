using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checkins.API.Auth
{
    public class HasScopeHandler : AuthorizationHandler<HasScopeRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, HasScopeRequirement scopeRequirement)
        {
            //Proceed only if User has the relevant scope claim
            if (!context.User.HasClaim(c => c.Type == "scope" && c.Issuer == scopeRequirement.Issuer))
                return Task.CompletedTask;

            //Tokenize the scope string into an array
            var scopes = context.User.FindFirst(c => c.Type == "scope" && c.Issuer == scopeRequirement.Issuer).Value.Split(' ');

            // Proceed only is the User has required scope

            if (scopes.Any(s => s == scopeRequirement.Scope))
                context.Succeed(scopeRequirement);

            return Task.CompletedTask;
        }
    }
}
