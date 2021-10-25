using IdentityServer4.Models;
using System.Collections.Generic;

namespace CharitySpacialSearcher.IdentityServer4.IdentityConfiguration
{
    public class Resources
    {
        //public static IEnumerable<IdentityResource> GetIdentityResources()
        //{
        //    return new[]
        //    {
        //        new IdentityResources.OpenId(),
        //        new IdentityResources.Profile(),
        //        new IdentityResources.Email(),
        //        new IdentityResource
        //        {
        //            Name = "role",
        //            UserClaims = new List<string> {"role"}
        //        }
        //    };
        //}

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new[]
            {
                new ApiResource
                {
                    Name = "charityApi",
                    DisplayName = "Charity Api",
                    Description = "Allow the application to access Charity Api on your behalf",
                    Scopes = new List<string> { "charityApi.read", "charityApi.write"},
                    ApiSecrets = new List<Secret> {new Secret("ProCodeGuide".Sha256())},
                    UserClaims = new List<string> {"role"}
                }
            };
        }
    }
}
