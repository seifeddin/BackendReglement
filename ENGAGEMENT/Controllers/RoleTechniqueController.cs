using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using ENGAGEMENT.CORE.Dto;
using ENGAGEMENT.SERVICES.Interfaces;

namespace ENGAGEMENT.Controllers
{
    [RoutePrefix("api/RoleTechnique")]
    public class RoleTechniqueController : ApiController
    {
        private readonly IRoleTechniqueService service;
        private readonly IMapper mapper;

        public RoleTechniqueController(IRoleTechniqueService service, IMapper mapper)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        // GET: api/RoleTechnique
        public IEnumerable<RoleTechniqueDto> Get()
        {
            return this.service.GetAll().Select(this.mapper.Map<RoleTechniqueDto>);
        }

        // GET: api/RoleTechnique/5
        public RoleTechniqueDto Get(int id)
        {
            return this.mapper.Map<RoleTechniqueDto>(this.service.GetById(id));
        }

        [HttpGet]
        [Route("GetLookup", Name = "GetLookup")]
        public List<LookupDto> GetLookup()
        {
            return this.service.GetLookupDto();
        }

        // POST: api/RoleTechnique
        public RoleTechniqueDto Post([FromBody]RoleTechniqueDto roleTechniqueDto)
        {
            if (ModelState.IsValid)
            {
                return this.service.Insert(roleTechniqueDto);
            }

            return null;
        }

        // PUT: api/RoleTechnique/5
        public RoleTechniqueDto Put(int id, [FromBody]RoleTechniqueDto roleTechniqueDto)
        {
            if (ModelState.IsValid)
            {
                return this.service.Update(roleTechniqueDto);
            }

            return null;
        }

        // DELETE: api/RoleTechnique/5
        public void Delete(int id)
        {
            this.service.Delete(id);
        }
    }
}