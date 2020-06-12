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
    [RoutePrefix("api/RubriqueRetenu")]
    public class RubriqueRetenuController : ApiController
    {
        private readonly IRubriqueRetenuService service;
        private readonly IMapper mapper;
        public RubriqueRetenuController(IRubriqueRetenuService service, IMapper mapper)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        // GET: api/RubriqueRetenu
        public IEnumerable<RubriqueRetenuDto> Get()
        {
            return this.service.GetAll().Select(this.mapper.Map<RubriqueRetenuDto>);
        }

        // GET: api/RubriqueRetenu/5
        public RubriqueRetenuDto Get(int id)
        {
            return this.mapper.Map<RubriqueRetenuDto>(this.service.GetById(id));
        }

        [HttpGet]
        [Route("GetLookup", Name = "GetLookupRubriqueRetenu")]
        public List<LookupDto> GetLookup()
        {
            return this.service.GetLookupDto();
        }

        // POST: api/RubriqueRetenu
        public RubriqueRetenuDto Post([FromBody]RubriqueRetenuDto rubriqueRetenuDto)
        {
            if (ModelState.IsValid)
            {
                return this.service.Insert(rubriqueRetenuDto);
            }

            return null;
        }

        // PUT: api/RubriqueRetenu/5
        public RubriqueRetenuDto Put(int id, [FromBody]RubriqueRetenuDto rubriqueRetenuDto)
        {
            if (ModelState.IsValid)
            {
                return this.service.Update(rubriqueRetenuDto);
            }

            return null;
        }

        // DELETE: api/RubriqueRetenu/5
        public void Delete(int id)
        {
            this.service.Delete(id);
        }
    }
}
