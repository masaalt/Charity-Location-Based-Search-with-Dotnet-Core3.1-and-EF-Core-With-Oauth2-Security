using IdentityServer4.Models;
using System.Collections.Generic;

namespace CharitySpacialSearcher.IdentityServer4.IdentityConfiguration
{
    public class Clients
    {
        public static IEnumerable<Client> Get()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "charityApi",
                    ClientName = "ASP.NET Core Charity Api",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = new List<Secret> {new Secret("medisa".Sha256())},
                    AllowedScopes = new List<string> {"charityApi.read"}
                }
            };
        }
    }
}
