using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ENGAGEMENT.SERVICES.Interfaces;

namespace ENGAGEMENT.Controllers
{
    [RoutePrefix("api/Rubrique")]
    public class RubriqueController : ApiController
    {
        private readonly IRubriqueService service;

        public RubriqueController(IRubriqueService service)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
        }
        // GET: api/Rubrique
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Rubrique/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Rubrique
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Rubrique/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Rubrique/5
        public void Delete(int id)
        {
        }
    }
}
