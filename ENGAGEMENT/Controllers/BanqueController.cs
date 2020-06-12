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
    [RoutePrefix("api/Banque")]
    public class BanqueController : ApiController
    {
        private readonly IBanqueService service;
        private readonly IMapper mapper;
        
        public BanqueController(IBanqueService service, IMapper mapper)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        // GET: api/Banque
        public IEnumerable<BanqueDto> Get()
        {
            return this.service.GetAll().Select(this.mapper.Map<BanqueDto>);
        }

        // GET: api/Banque/5
        public BanqueDto Get(int id)
        {
            return this.mapper.Map<BanqueDto>(this.service.GetById(id));
        }

        [HttpGet]
        [Route("GetLookup", Name = "GetLookup")]
        public List<LookupDto> GetLookup()
        {
            return this.service.GetLookupDto();
        }
        // POST: api/Banque
        public BanqueDto Post([FromBody]BanqueDto banqueDto)
        {
            if (ModelState.IsValid)
            {
                return this.service.Insert(banqueDto);
            }
            return null;
        }

        // PUT: api/Banque/5
        public BanqueDto Put(int id, [FromBody]BanqueDto banqueDto)
        {
            if (ModelState.IsValid)
            {
                return this.service.Update(banqueDto);
            }
            return null;
        }

        // DELETE: api/Banque/5
        public void Delete(int id)
        {
            this.service.Delete(id);
        }
    }
}
