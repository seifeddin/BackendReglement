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
    [RoutePrefix("api/Devise")]
    public class DeviseController : ApiController
    {
        private readonly IDeviseService service;
        private readonly IMapper mapper;

        public DeviseController(IDeviseService service, IMapper mapper)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        // GET: api/Devise
        public IEnumerable<DeviseDto> Get()
        {
            return this.service.GetAll().Select(this.mapper.Map<DeviseDto>);
        }

        // GET: api/Devise/5
        public DeviseDto Get(int id)
        {
            return this.mapper.Map<DeviseDto>(this.service.GetById(id));
        }

        [HttpGet]
        [Route("GetLookup", Name = "GetLookup")]
        public List<LookupDto> GetLookup()
        {
            return this.service.GetLookupDto();
        }

        // POST: api/Devise
        public DeviseDto Post([FromBody]DeviseDto deviseDto)
        {
            if (ModelState.IsValid)
            {
                return this.service.Insert(deviseDto);
            }

            return null;
        }

        // PUT: api/Devise/5
        public DeviseDto Put(int id, [FromBody]DeviseDto deviseDto)
        {
            if (ModelState.IsValid)
            {
                return this.service.Update(deviseDto);
            }

            return null;
        }

        // DELETE: api/Devise/5
        public void Delete(int id)
        {
            this.service.Delete(id);
        }
    }
}
