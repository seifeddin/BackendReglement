using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ENGAGEMENT.SERVICES.Interfaces;

namespace ENGAGEMENT.Controllers
{
    [RoutePrefix("api/DetailReglement")]
    public class DetailReglementController : ApiController
    {
        private readonly IDetailReglementService service;

        public DetailReglementController(IDetailReglementService service)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
        }

        // GET: api/DetailReglement
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/DetailReglement/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/DetailReglement
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/DetailReglement/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/DetailReglement/5
        public void Delete(int id)
        {
        }
    }
}
