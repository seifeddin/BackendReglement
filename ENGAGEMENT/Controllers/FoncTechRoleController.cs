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
    [RoutePrefix("api/FoncTechRole")]
    public class FoncTechRoleController : ApiController
    {
        private readonly IFoncTechRoleService service;
        private readonly IMapper mapper;

        public FoncTechRoleController(IFoncTechRoleService service, IMapper mapper)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        // GET: api/FoncTechRole
        public IEnumerable<FoncTechRoleDto> Get()
        {
            return this.service.GetAll().Select(this.mapper.Map<FoncTechRoleDto>);
        }

        // GET: api/FoncTechRole/5
        public FoncTechRoleDto Get(int id)
        {
            return this.mapper.Map<FoncTechRoleDto>(this.service.GetById(id));
        }

        [HttpGet]
        [Route("GetLookup", Name = "GetLookup")]
        public List<LookupDto> GetLookup()
        {
            return this.service.GetLookupDto();
        }
        // POST: api/FoncTechRole
        public FoncTechRoleDto Post([FromBody]FoncTechRoleDto foncTechRoleDto)
        {
            if (ModelState.IsValid)
            {
                return this.service.Insert(foncTechRoleDto);
            }

            return null;
        }

        // PUT: api/FoncTechRole/5
        public FoncTechRoleDto Put(int id, [FromBody]FoncTechRoleDto foncTechRoleDto)
        {
            if (ModelState.IsValid)
            {
                return this.service.Update(foncTechRoleDto);
            }

            return null;
        }

        // DELETE: api/FoncTechRole/5
        public void Delete(int id)
        {
            this.service.Delete(id);
        }
    }
}
