using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ENGAGEMENT.SERVICES.Interfaces;

namespace ENGAGEMENT.Controllers
{
    [RoutePrefix("api/RoleFonctionnel")]
    public class RoleFonctionnelController : ApiController
    {
        private readonly IRoleFonctionnelService service;

        public RoleFonctionnelController(IRoleFonctionnelService service)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
        }
        // GET: api/RoleFonctionnel
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/RoleFonctionnel/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/RoleFonctionnel
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/RoleFonctionnel/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/RoleFonctionnel/5
        public void Delete(int id)
        {
        }
    }
}
