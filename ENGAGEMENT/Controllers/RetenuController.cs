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
    [RoutePrefix("api/Retenu")]
    public class RetenuController : ApiController
    {
        private readonly IRetenuService service;
        private readonly IMapper mapper;

        public RetenuController(IRetenuService service)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
        }
        // GET: api/Retenu
        public IEnumerable<RetenuDto> Get()
        {
            return this.service.GetAll().Select(this.mapper.Map<RetenuDto>);
        }

        // GET: api/Retenu/5
        public RetenuDto Get(int id)
        {
            return this.mapper.Map<RetenuDto>(this.service.GetById(id));
        }

        [HttpGet]
        [Route("GetLookup", Name = "GetLookupRetenu")]
        public List<LookupDto> GetLookup()
        {
            return this.service.GetLookupDto();
        }

        // POST: api/Retenu
        public RetenuDto Post([FromBody]RetenuDto retenuDto)
        {
            if (ModelState.IsValid)
            {
                return this.service.Insert(retenuDto);
            }

            return null;
        }

        // PUT: api/Retenu/5
        public RetenuDto Put(int id, [FromBody]RetenuDto retenuDto)
        {
            if (ModelState.IsValid)
            {
                return this.service.Update(retenuDto);
            }

            return null;
        }

        // DELETE: api/Retenu/5
        public void Delete(int id)
        {
            this.service.Delete(id);
        }
        [HttpPost]
        [Route("Validate", Name = "validateRetenu")]
        public RetenuDto Validate([FromBody]RetenuDto retenu)
        {
            if (ModelState.IsValid)
            {

               return this.service.InsertWithTransaction(retenu);
            }
            return null;

        }
    }
}
