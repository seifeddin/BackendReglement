using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ENGAGEMENT.Controllers
{
    using ENGAGEMENT.Models;
    using Microsoft.IdentityModel.Tokens;
    using System.IdentityModel.Tokens.Jwt;
    using System.Security.Claims;
    using System.Text;

    [RoutePrefix("api/Account")]
    public class AccountController : ApiController
    {
        [HttpPost]
        [Route("GetToken",Name ="GetToken")]
        [AllowAnonymous]
        public User GetToken([FromBody]User _user)
        {

            string key = "A C B d A kK l MPON akqsk,d"; //Secret key which will be used later during validation    
            var issuer = "http://localhost:52549";  //normally this will be your site URL    

            User user = new User { FirstName = "Aida", LastName = "Athamnia", UserName = "test", Password = "Test" };
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            //Create a List of Claims, Keep claims name short    
            var permClaims = new List<Claim>();
            permClaims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));
            permClaims.Add(new Claim("username",""));
            permClaims.Add(new Claim("password", ""));

            //Create Security Token object by giving required parameters    
            var token = new JwtSecurityToken(issuer, //Issure    
                            issuer,  //Audience    
                            permClaims,
                            expires: DateTime.Now.AddDays(1),
                            signingCredentials: credentials);
            var jwt_token = new JwtSecurityTokenHandler().WriteToken(token);
            user.Token = jwt_token;

            return user;

        }

        [HttpPost]
        [Route("GetName1", Name = "GetName1")]
        public string GetName1()
        {
            if (User.Identity.IsAuthenticated)
            {
                var identity = User.Identity as ClaimsIdentity;
                if (identity != null)
                {
                    IEnumerable<Claim> claims = identity.Claims;
                }
                return "Valid";
            }
            else
            {
                return "Invalid";
            }
        }

        [HttpPost]
        [Route("GetName2", Name = "GetName2")]
        public Object GetName2()
        {
            var identity = User.Identity as ClaimsIdentity;
            if (identity != null)
            {
                IEnumerable<Claim> claims = identity.Claims;
                var name = claims.Where(p => p.Type == "name").FirstOrDefault()?.Value;
                return new
                {
                    data = name
                };

            }
            return null;
        }



    }
}
