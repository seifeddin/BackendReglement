using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ENGAGEMENT.SERVICES.Interfaces;

namespace ENGAGEMENT.Controllers
{
    [RoutePrefix("api/FoncTechRole")]
    public class FoncTechRoleController : ApiController
    {
        private readonly IFoncTechRoleService service;

        public FoncTechRoleController(IFoncTechRoleService service)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
        }
        // GET: api/FoncTechRole
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/FoncTechRole/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/FoncTechRole
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/FoncTechRole/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/FoncTechRole/5
        public void Delete(int id)
        {
        }
    }
}
