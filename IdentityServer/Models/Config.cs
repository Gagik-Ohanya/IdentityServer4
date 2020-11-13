using IdentityServer4;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace IdentityServer.Models
{
    public class Config
    {
        public static IEnumerable<Client> GetClients()
        {
            return new Client[]
            {
                new Client
                {
                    ClientId = "ConsoleApp",
                    ClientName = "DemoConsole",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowedScopes = { "resourceApi" },
                    ClientSecrets = { new Secret("clientsecret".Sha256()) }
                },
                new Client
                {
                    ClientId = "MvcApp",
                    ClientName = "DemoMvc",
                    AllowedGrantTypes = GrantTypes.Code,
                    RedirectUris = { "https://localhost:44388/signin-oidc" },
                    PostLogoutRedirectUris = { "https://localhost:44388/signout-callback-oidc" },
                    AllowedScopes = 
                    { 
                        IdentityServerConstants.StandardScopes.OpenId, 
                        IdentityServerConstants.StandardScopes.Profile,
                        "resourceApi"
                    },
                    ClientSecrets = { new Secret("clientsecret".Sha256()) }
                }
            };
        }

        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new IdentityResource[]
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile()
            };
        }

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new ApiResource[]
            {

            };
        }

        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new List<ApiScope> 
            { 
                new ApiScope("resourceApi", "Target API")
            };
        }
    }
}