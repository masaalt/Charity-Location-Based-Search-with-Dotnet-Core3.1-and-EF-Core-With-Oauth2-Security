using IdentityModel;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;

namespace CharitySpacialSearcher.IdentityServer4.IdentityConfiguration
{
    public class Users
    {
        public static List<TestUser> Get()
        {
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "admin",
                    Username = "admin",
                    Password = "123",
                    Claims = new List<Claim>
                    {
                        new Claim(JwtClaimTypes.Email, "support@procodeguide.com"),
                        new Claim(JwtClaimTypes.Role, "admin"),
                        new Claim(JwtClaimTypes.WebSite, "https://procodeguide.com")
                    }
                },
                new TestUser
                {
                    SubjectId = "manager",
                    Username = "manager",
                    Password = "123",
                    Claims = new List<Claim>
                    {
                        new Claim(JwtClaimTypes.Email, "support@procodeguide.com"),
                        new Claim(JwtClaimTypes.Role, "manager"),
                        new Claim(JwtClaimTypes.WebSite, "https://procodeguide.com")
                    }
                },
                new TestUser
                {
                    SubjectId = "user",
                    Username = "user",
                    Password = "123",
                    Claims = new List<Claim>
                    {
                        new Claim(JwtClaimTypes.Email, "support@procodeguide.com"),
                        new Claim(JwtClaimTypes.Role, "user"),
                        new Claim(JwtClaimTypes.WebSite, "https://procodeguide.com")
                    }
                }
            };
        }
    }
}
