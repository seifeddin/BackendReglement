using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ENGAGEMENT.SERVICES.Interfaces;

namespace ENGAGEMENT.Controllers
{
    [RoutePrefix("api/RubriqueRetenu")]
    public class RubriqueRetenuController : ApiController
    {
        private readonly IRubriqueRetenuService service;
        public RubriqueRetenuController(IRubriqueRetenuService service)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
        }
        // GET: api/RubriqueRetenu
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/RubriqueRetenu/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/RubriqueRetenu
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/RubriqueRetenu/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/RubriqueRetenu/5
        public void Delete(int id)
        {
        }
    }
}
