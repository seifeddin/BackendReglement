using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ENGAGEMENT.SERVICES.Interfaces;

namespace ENGAGEMENT.Controllers
{
    [RoutePrefix("api/Annexe")]
    public class AnnexeController : ApiController
    {
        private readonly IAnnexeService service;
        public AnnexeController(IAnnexeService service)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
        }

        // GET: api/Annexe
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Annexe/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Annexe
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Annexe/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Annexe/5
        public void Delete(int id)
        {
        }
    }
}
