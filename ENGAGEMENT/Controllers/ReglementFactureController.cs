using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ENGAGEMENT.Controllers
{
    public class ReglementFactureController : ApiController
    {
        // GET: api/ReglementFacture
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ReglementFacture/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ReglementFacture
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ReglementFacture/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ReglementFacture/5
        public void Delete(int id)
        {
        }
    }
}
