using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ENGAGEMENT.SERVICES.Interfaces;

namespace ENGAGEMENT.Controllers
{
    [RoutePrefix("api/ModeReglement")]
    public class ModeReglementController : ApiController
    {
        private readonly IModeReglementService service;

        public ModeReglementController(IModeReglementService service)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
        }
        // GET: api/ModeReglement
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ModeReglement/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ModeReglement
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ModeReglement/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ModeReglement/5
        public void Delete(int id)
        {
        }
    }
}
