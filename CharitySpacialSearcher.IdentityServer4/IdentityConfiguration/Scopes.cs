using IdentityServer4.Models;
using System.Collections.Generic;

namespace CharitySpacialSearcher.IdentityServer4.IdentityConfiguration
{
    public class Scopes
    {
        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new[]
            {
                new ApiScope("charityApi.read", "Read Access to Charity API"),
                new ApiScope("charityApi.write", "Write Access to Charity API"),
            };
        }
    }
}
