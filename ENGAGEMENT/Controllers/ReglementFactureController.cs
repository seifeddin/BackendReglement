using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using ENGAGEMENT.CORE.Dto;
using ENGAGEMENT.SERVICES.Interfaces;

namespace ENGAGEMENT.Controllers
{
    [RoutePrefix("api/ReglementFacture")]
    public class ReglementFactureController : ApiController
    {
        private readonly IReglementFactureService service;
        private readonly IMapper mapper;

        public ReglementFactureController(IReglementFactureService service, IMapper mapper)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        // GET: api/ReglementFacture
        public IEnumerable<ReglementFactureDto> Get()
        {
            return this.service.GetAll().Select(this.mapper.Map<ReglementFactureDto>);
        }

        // GET: api/ReglementFacture/5
        public ReglementFactureDto Get(int id)
        {
            return this.mapper.Map<ReglementFactureDto>(this.service.GetById(id));
        }

        // POST: api/ReglementFacture
        public ReglementFactureDto Post([FromBody]ReglementFactureDto reglementFactureDto)
        {
            if (ModelState.IsValid)
            {
                return this.service.Insert(reglementFactureDto);
            }

            return null;
        }

        // PUT: api/ReglementFacture/5
        public ReglementFactureDto Put(int id, [FromBody]ReglementFactureDto reglementFactureDto)
        {
            if (ModelState.IsValid)
            {
                return this.service.Update(reglementFactureDto);
            }

            return null;
        }

        // DELETE: api/ReglementFacture/5
        public void Delete(int id)
        {
            this.service.Delete(id);
        }
    }
}
