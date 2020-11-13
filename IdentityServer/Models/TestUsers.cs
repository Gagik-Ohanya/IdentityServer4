using IdentityModel;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IdentityServer.Models
{
    public class TestUsers
    {
        public static List<TestUser> Users = new List<TestUser>
        {
            new TestUser
            {
                SubjectId = "1",
                Username = "gagik9",
                Password = "U*I(O)",
                IsActive = true,
                Claims =
                {
                    new Claim("office_number", "25"),
                    new Claim(JwtClaimTypes.Name, "Gagik Ohanyan"),
                    new Claim(JwtClaimTypes.GivenName, "Gagik"),
                    new Claim(JwtClaimTypes.FamilyName, "Ohanyan"),
                    new Claim(JwtClaimTypes.Email, "gagik.ohanyan@email.com"),
                    new Claim(JwtClaimTypes.EmailVerified, "true"),
                    new Claim(JwtClaimTypes.WebSite, "http://go.com")
                }
            },
            new TestUser
            {
                SubjectId = "88421113",
                Username = "bob",
                Password = "bob",
                Claims =
                {
                    new Claim(JwtClaimTypes.Name, "Bob Smith"),
                    new Claim(JwtClaimTypes.GivenName, "Bob"),
                    new Claim(JwtClaimTypes.FamilyName, "Smith"),
                    new Claim(JwtClaimTypes.Email, "BobSmith@email.com"),
                    new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                    new Claim(JwtClaimTypes.WebSite, "http://bob.com")
                }
            }
        };
    }
}