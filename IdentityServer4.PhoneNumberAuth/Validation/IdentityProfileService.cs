using IdentityServer4.Models;
using IdentityServer4.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IdentityServer4.PhoneNumberAuth.Validation
{
    public class IdentityProfileService : IProfileService
    {
        public async Task GetProfileDataAsync(ProfileDataRequestContext context)
        {
            //IsActiveAsync turns out to be true 
            //Here you add the claims that you want in the access token


            var claims = new List<Claim>();

            claims.Add(new Claim("phone_number", "+198989822"));

            context.IssuedClaims = claims;
        }

        public async Task IsActiveAsync(IsActiveContext context)
        {
            bool isActive = true;
            /*
                Implement some code to determine that the user is actually active 
                and set isActive to true
            */
            context.IsActive = isActive;
        }
    }
}
