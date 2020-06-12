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
    [RoutePrefix("api/Annexe")]
    public class AnnexeController : ApiController
    {
        private readonly IAnnexeService service;
        private readonly IMapper mapper;
        public AnnexeController(IAnnexeService service, IMapper mapper)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        // GET: api/Annexe
        public IEnumerable<AnnexeDto> Get()
        {
            return this.service.GetAll().Select(this.mapper.Map<AnnexeDto>);
        }

        // GET: api/Annexe/5
        public AnnexeDto Get(int id)
        {
            return this.mapper.Map<AnnexeDto>(this.service.GetById(id));
        }

        [HttpGet]
        [Route("GetLookup", Name = "GetLookupAnnexe")]
        public List<LookupDto> GetLookup()
        {
            return this.service.GetLookupDto();
        }
        // POST: api/Annexe
        public AnnexeDto Post([FromBody]AnnexeDto annexeDto)
        {
            if (ModelState.IsValid)
            {
               return this.service.Insert(annexeDto); 
            }
            return null;
        }

        // PUT: api/Annexe/5
        public AnnexeDto Put(int id, [FromBody]AnnexeDto annexeDto)
        {
            if (ModelState.IsValid)
            {
                return this.service.Update(annexeDto);
            }
            return null;
        }

        // DELETE: api/Annexe/5
        public void Delete(int id)
        {
            this.service.Delete(id);
        }
    }
}
