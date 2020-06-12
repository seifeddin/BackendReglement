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
    [RoutePrefix("api/ModeReglement")]
    public class ModeReglementController : ApiController
    {
        private readonly IModeReglementService service;
        private readonly IMapper mapper;

        public ModeReglementController(IModeReglementService service, IMapper mapper)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(service));
        }
        // GET: api/ModeReglement
        public IEnumerable<ModeReglementDto> Get()
        {
            return this.service.GetAll().Select(this.mapper.Map<ModeReglementDto>);
        }

        // GET: api/ModeReglement/5
        public ModeReglementDto Get(int id)
        {
            return this.mapper.Map<ModeReglementDto>(this.service.GetById(id));
        }
        [HttpGet]
        [Route("GetLookup", Name = "GetLookupModeReglement")]
        public List<LookupDto> GetLookup()
        {
            return this.service.GetLookupDto();
        }
        // POST: api/ModeReglement
        public ModeReglementDto Post([FromBody]ModeReglementDto modeReglementDto)
        {
            if (ModelState.IsValid)
            {
                return this.service.Insert(modeReglementDto);
            }

            return null;
        }

        // PUT: api/ModeReglement/5
        public ModeReglementDto Put(int id, [FromBody]ModeReglementDto modeReglementDto)
        {
            if (ModelState.IsValid)
            {
                return this.service.Update(modeReglementDto);
            }

            return null;
        }

        // DELETE: api/ModeReglement/5
        public void Delete(int id)
        {
            this.service.Delete(id);
        }
    }
}
