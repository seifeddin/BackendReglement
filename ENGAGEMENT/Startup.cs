using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Jwt;
using Owin;

[assembly: OwinStartup(typeof(ENGAGEMENT.Startup))]

namespace ENGAGEMENT
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Pour plus d'informations sur la configuration de votre application, visitez https://go.microsoft.com/fwlink/?LinkID=316888
            app.UseJwtBearerAuthentication(
               new JwtBearerAuthenticationOptions
               {
                   AuthenticationMode = AuthenticationMode.Active,
                   TokenValidationParameters = new TokenValidationParameters()
                   {
                    
                       ValidateIssuer = true,
                       ValidateAudience = true,
                       ValidateIssuerSigningKey = true,
                       ValidIssuer = "http://localhost:52549", //some string, normally web url,  
                       ValidAudience = "http://localhost:52549",
                       IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("A C B d A kK l MPON akqsk,d"))
                   }
                   //TokenValidationParameters = new TokenValidationParameters
                   //{
                   //    ValidateIssuerSigningKey = true,
                   //    IssuerSigningKey = new SymmetricSecurityKey(key),
                   //    ValidateIssuer = false,
                   //    ValidateAudience = false
                   //};
               });
        }
    }
}
