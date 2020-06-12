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
    [RoutePrefix("api/DetailReglement")]
    public class DetailReglementController : ApiController
    {
        private readonly IDetailReglementService service;
        private readonly IMapper mapper;

        public DetailReglementController(IDetailReglementService service, IMapper mapper)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        // GET: api/DetailReglement
        public IEnumerable<DetailReglementDto> Get()
        {
            return this.service.GetAll().Select(this.mapper.Map<DetailReglementDto>);
        }

        public IEnumerable<DetailReglementDto> GetByReglement(int id)
        {
            return this.service.GetAll().Where(x => x.IdReglement == id).Select(this.mapper.Map<DetailReglementDto>);
        }

        // GET: api/DetailReglement/5
        public DetailReglementDto Get(int id)
        {
            return this.mapper.Map<DetailReglementDto>(this.service.GetById(id));
        }

        [HttpGet]
      
        public List<LookupDto> GetLookup()
        {
            return this.service.GetLookupDto();
        }

        // POST: api/DetailReglement
        public DetailReglementDto Post([FromBody]DetailReglementDto detailReglementDto)
        {
            if (ModelState.IsValid)
            {
                return this.service.Insert(detailReglementDto);
            }

            return null;
        }

        // PUT: api/DetailReglement/5
        public DetailReglementDto Put(int id, [FromBody]DetailReglementDto detailReglementDto)
        {
            if (ModelState.IsValid)
            {
                return this.service.Update(detailReglementDto);
            }

            return null;
        }

        // DELETE: api/DetailReglement/5
        public void Delete(int id)
        {
            this.service.Delete(id);
        }
    }
}
