using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ENGAGEMENT.SERVICES.Interfaces;

namespace ENGAGEMENT.Controllers
{
    [RoutePrefix("api/Devise")]
    public class DeviseController : ApiController
    {
        private readonly IDeviseService service;

        public DeviseController(IDeviseService service)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
        }

        // GET: api/Devise
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Devise/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Devise
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Devise/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Devise/5
        public void Delete(int id)
        {
        }
    }
}
