﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ENGAGEMENT.SERVICES.Interfaces;

namespace ENGAGEMENT.Controllers
{
    public class RoleTechniqueController : ApiController
    {
        private readonly IRoleTechniqueService service;

        public RoleTechniqueController(IRoleTechniqueService service)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
        }

        // GET: api/RoleTechnique
        public IEnumerable<string> Get()
        {
            return new string[] {"value1", "value2"};
        }

        // GET: api/RoleTechnique/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/RoleTechnique
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/RoleTechnique/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/RoleTechnique/5
        public void Delete(int id)
        {
        }
    }
}