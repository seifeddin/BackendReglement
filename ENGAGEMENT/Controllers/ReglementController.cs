using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ENGAGEMENT.SERVICES.Interfaces;

namespace ENGAGEMENT.Controllers
{
    [RoutePrefix("api/Reglement")]
    public class ReglementController : ApiController
    {
        private readonly IReglementService service;

        public ReglementController(IReglementService service)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
        }
        // GET: api/Reglement
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Reglement/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Reglement
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Reglement/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Reglement/5
        public void Delete(int id)
        {
        }
    }
}
