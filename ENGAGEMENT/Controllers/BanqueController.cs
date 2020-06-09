using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ENGAGEMENT.SERVICES.Interfaces;

namespace ENGAGEMENT.Controllers
{
    [RoutePrefix("api/Banque")]
    public class BanqueController : ApiController
    {
        private readonly IBanqueService service;
        
        public BanqueController(IBanqueService service)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
        }

        // GET: api/Banque
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Banque/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Banque
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Banque/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Banque/5
        public void Delete(int id)
        {
        }
    }
}
