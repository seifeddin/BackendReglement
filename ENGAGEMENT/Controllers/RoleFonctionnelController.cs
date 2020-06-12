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
    [RoutePrefix("api/RoleFonctionnel")]
    public class RoleFonctionnelController : ApiController
    {
        private readonly IRoleFonctionnelService service;
        private readonly IMapper mapper;

        public RoleFonctionnelController(IRoleFonctionnelService service, IMapper mapper)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        // GET: api/RoleFonctionnel
        public IEnumerable<RoleFonctionnelDto> Get()
        {
            return this.service.GetAll().Select(this.mapper.Map<RoleFonctionnelDto>);
        }

        // GET: api/RoleFonctionnel/5
        public RoleFonctionnelDto Get(int id)
        {
            return this.mapper.Map<RoleFonctionnelDto>(this.service.GetById(id));
        }

        [HttpGet]
        [Route("GetLookup", Name = "GetLookupRoleFonctionnel")]
        public List<LookupDto> GetLookup()
        {
            return this.service.GetLookupDto();
        }

        // POST: api/RoleFonctionnel
        public RoleFonctionnelDto Post([FromBody]RoleFonctionnelDto roleFonctionnelDto)
        {
            if (ModelState.IsValid)
            {
                return this.service.Insert(roleFonctionnelDto);
            }

            return null;
        }

        // PUT: api/RoleFonctionnel/5
        public RoleFonctionnelDto Put(int id, [FromBody]RoleFonctionnelDto roleFonctionnelDto)
        {
            if (ModelState.IsValid)
            {
                return this.service.Update(roleFonctionnelDto);
            }

            return null;
        }

        // DELETE: api/RoleFonctionnel/5
        public void Delete(int id)
        {
            this.service.Delete(id);
        }
    }
}
