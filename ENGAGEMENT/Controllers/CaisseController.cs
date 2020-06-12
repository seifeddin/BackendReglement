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
    public class CaisseController : ApiController
    {
        private readonly ICaisseService service;
        private readonly IMapper mapper;
        public CaisseController(ICaisseService service, IMapper mapper)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        // GET: api/Caisse
        public IEnumerable<CaisseDto> Get()
        {
            return this.service.GetAll().Select(this.mapper.Map<CaisseDto>);
        }

        // GET: api/Caisse/5
        public CaisseDto Get(int id)
        {
            return this.mapper.Map<CaisseDto>(this.service.GetById(id));
        }

        [HttpGet]
        [Route("GetLookup", Name = "GetLookup")]
        public List<LookupDto> GetLookup()
        {
            return this.service.GetLookupDto();
        }

        // POST: api/Caisse
        public CaisseDto Post([FromBody]CaisseDto caisseDto)
        {
            if (ModelState.IsValid)
            {
               return this.service.Insert(caisseDto);
            }

            return null;
        }

        // PUT: api/Caisse/5
        public CaisseDto Put(int id, [FromBody]CaisseDto caisseDto)
        {
            if (ModelState.IsValid)
            {
                return this.service.Update(caisseDto);
            }

            return null;
        }

        // DELETE: api/Caisse/5
        public void Delete(int id)
        {
            this.service.Delete(id);
        }
    }
}
