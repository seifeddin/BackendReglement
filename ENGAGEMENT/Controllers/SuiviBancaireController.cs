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
    [RoutePrefix("api/SuiviBancaire")]
    public class SuiviBancaireController : ApiController
    {
        private readonly ISuiviBancaireSevice service;
        private readonly IMapper mapper;

        public SuiviBancaireController(ISuiviBancaireSevice service, IMapper mapper)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        [HttpGet]
        [Route("GetReglementPourSuivi", Name = "GetReglementPourSuivi")]
        public List<CanvasReglement> GetReglementPourSuivi()
        {
            return this.service.GetReglementPourSuivi();
        }
        // GET: api/SuiviBancaire
        public IEnumerable<SuiviBancaireDto> Get()
        {
            return this.service.GetAll().Select(this.mapper.Map<SuiviBancaireDto>);
        }

        // GET: api/SuiviBancaire/5
        public SuiviBancaireDto Get(int id)
        {
            return this.mapper.Map<SuiviBancaireDto>(this.service.GetById(id));
        }

        [HttpGet]
        [Route("GetLookup", Name = "GetLookupSuiviBancaire")]
        public List<LookupDto> GetLookup()
        {
            return this.service.GetLookupDto();
        }

        // POST: api/SuiviBancaire
        public SuiviBancaireDto Post([FromBody]SuiviBancaireDto suiviBancaireDto)
        {
            if (ModelState.IsValid)
            {
                return this.service.Insert(suiviBancaireDto);
            }

            return null;
        }

        // PUT: api/SuiviBancaire/5
        public SuiviBancaireDto Put(int id, [FromBody]SuiviBancaireDto suiviBancaireDto)
        {
            if (ModelState.IsValid)
            {
                return this.service.Update(suiviBancaireDto);
            }

            return null;
        }

        // DELETE: api/SuiviBancaire/5
        public void Delete(int id)
        {
            this.service.Delete(id);
        }
    }
}
