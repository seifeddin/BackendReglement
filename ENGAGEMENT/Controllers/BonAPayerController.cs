using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using ENGAGEMENT.CORE.Dto;
using ENGAGEMENT.DATA.Model;
using ENGAGEMENT.SERVICES.Interfaces;

namespace ENGAGEMENT.Controllers
{
    [RoutePrefix("api/BonAPayer")]
    public class BonAPayerController : ApiController
    {
        private readonly IBonAPayerService service;
        private readonly IMapper mapper;
        public BonAPayerController(IBonAPayerService service, IMapper mapper)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        // GET: api/BonAPayer
        public IEnumerable<BonAPayerDto> Get()
        {
            return this.service.GetAll().Select(this.mapper.Map<BonAPayerDto>);
        }

        // GET: api/BonAPayer/5
        public BonAPayerDto Get(int id)
        {
            return this.mapper.Map<BonAPayerDto>(this.service.GetById(id));
        }

        [HttpGet]
        [Route("GetLookup", Name = "GetLookupBonAPayer")]
        public List<LookupDto> GetLookup()
        {
            return this.service.GetLookupDto();
        }

        // POST: api/BonAPayer
        public BonAPayerDto Post([FromBody]BonAPayerDto bonAPayerDto)
        {
            if (ModelState.IsValid)
            {
                return this.service.Insert(bonAPayerDto);
            }

            return null;
        }

        // PUT: api/BonAPayer/5
        public BonAPayerDto Put([FromBody]BonAPayerDto bonAPayerDto)
        {
            if (ModelState.IsValid)
            {
                return this.service.Update(bonAPayerDto);
            }

            return null;
        }

        // DELETE: api/BonAPayer/5
        public void Delete(int id)
        {
            this.service.Delete(id);
        }

        [HttpGet]
        [Route("GetAllBonApayer", Name = "GetAllBon")]
        public List<ListBonAPayer> GetAll()
        { return this.service.GetAllBonApayer(); }


        [HttpGet]
        [Route("GetBonsRecuperes", Name = "GetBonsRecuperes")]
        public List<ListBonAPayer> GetBonsRecuperes()
        { return this.service.GetBonsRecuperes(); }

    }
}
