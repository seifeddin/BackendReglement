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
    [RoutePrefix("api/Reglement")]
    public class ReglementController : ApiController
    {
        private readonly IReglementService service;
        private readonly IMapper mapper;
        public ReglementController(IReglementService service,IMapper mapper)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        // GET: api/Reglement
        public IEnumerable<ReglementDto> Get()
        {
            return this.service.GetAll().Select(this.mapper.Map<ReglementDto>);
        }

        // GET: api/Reglement/5
        public ReglementDto Get(int id)
        {
            return this.mapper.Map<ReglementDto>(this.service.GetById(id));
        }

        [HttpGet]
        [Route("GetLookup", Name = "GetLookup")]
        public List<LookupDto> GetLookup()
        {
            return this.service.GetLookupDto();
        }

        // POST: api/Reglement
        public ReglementDto Post([FromBody]ReglementDto reglementDto)
        {
            if (ModelState.IsValid)
            {
                return this.service.Insert(reglementDto);
            }

            return null;
        }

        // PUT: api/Reglement/5
        public ReglementDto Put(int id, [FromBody]ReglementDto reglementDto)
        {
            if (ModelState.IsValid)
            {
                return this.service.Update(reglementDto);
            }

            return null;
        }

        // DELETE: api/Reglement/5
        public void Delete(int id)
        {
            this.service.Delete(id);
        }
    }
}
