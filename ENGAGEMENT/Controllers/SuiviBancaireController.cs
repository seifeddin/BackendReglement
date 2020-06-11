using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ENGAGEMENT.SERVICES.Interfaces;

namespace ENGAGEMENT.Controllers
{
    [RoutePrefix("api/SuiviBancaire")]
    public class SuiviBancaireController : ApiController
    {
        private readonly ISuiviBancaireSevice service;

        public SuiviBancaireController(ISuiviBancaireSevice service)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
        }
        // GET: api/SuiviBancaire
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SuiviBancaire/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SuiviBancaire
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SuiviBancaire/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SuiviBancaire/5
        public void Delete(int id)
        {
        }
    }
}
