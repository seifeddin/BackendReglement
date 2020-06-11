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

        // POST: api/Annexe
        public void Post([FromBody]AnnexeDto annexeDto)
        {
            if (ModelState.IsValid)
            {
                //this.service.Insert(this.mapper.Map<Annexe>(annexeDto)); il faut changer le service pour utiliser DTO
            }
        }

        // PUT: api/Annexe/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Annexe/5
        public void Delete(int id)
        {
        }
    }
}
