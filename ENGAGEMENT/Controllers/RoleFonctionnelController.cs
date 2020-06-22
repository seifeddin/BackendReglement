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
    [RoutePrefix("api/RoleFonctionnel")]
    public class RoleFonctionnelController : ApiController
    {
        private readonly IRoleFonctionnelService service;
        private readonly IRoleTechniqueService roleTechniqueServiceservice;
        private readonly IMapper mapper;

        public RoleFonctionnelController(IRoleFonctionnelService service, IRoleTechniqueService roleTechniqueServiceservice, IMapper mapper)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
            this.roleTechniqueServiceservice = roleTechniqueServiceservice ??
                                               throw new ArgumentNullException(nameof(roleTechniqueServiceservice));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        // GET: api/RoleFonctionnel
        public IEnumerable<RoleFonctionnelDto> Get()
        {
            return this.service.GetAll().Select(this.mapper.Map<RoleFonctionnelDto>);
        }

        // GET: api/RoleFonctionnel/5
        [Route("GetById/{id}",Name = "GetRoleFonctionnelById")]
        public RoleFonctionnelDto GetById(int id)
        {
            return this.mapper.Map<RoleFonctionnelDto>(this.service.GetById(id));
        }

        [HttpGet]
        [Route("GetRoleTechniqueDtosByRoleFonctionel/{id:int}", Name = "GetRoleTechniqueDtosByRoleFonctionelId")]
        public List<RoleTechniqueDto> GetRoleTechniqueDtosByRoleFonctionel(int id)
        {
            List<RoleTechniqueDto> resultat = new List<RoleTechniqueDto>();
            foreach (var item in this.service.GetById(id).FoncTechRole)
            {
                resultat.Add(this.mapper.Map<RoleTechniqueDto>(this.roleTechniqueServiceservice.GetById(item.IdTechRole)));
            }
            return resultat;
        }
        [HttpGet]
        [Route("GetNotAffectedRoleTechnique/{id:int}", Name = "GetNotAffectedRoleTechnique")]
        public List<RoleTechniqueDto> GetNotAffectedRoleTechnique(int id)
        {
            return this.roleTechniqueServiceservice.GetNotAffectedRoleTechnique(id);
        }

        [HttpGet]
        [Route("GetLookup", Name = "GetLookupRoleFonctionnel")]
        public List<LookupDto> GetLookup()
        {
            return this.service.GetLookupDto();
        }
        [HttpPost]
        [Route("AddRoleTechniqueToRoleFonctionnel",Name = "AddRoleTechniqueToRoleFonctionnel")]
        public RoleFonctionnelDto AddRoleTechniqueToRoleFonctionnel([FromBody] RoleFonctionnelDto roleFonctionnelDto)
        {
            if (ModelState.IsValid)
            {
                return this.service.AddRoleTechniqueToRoleFonctionnel(roleFonctionnelDto);
            }

            return null;
        }

        // POST: api/RoleFonctionnel
        public RoleFonctionnelDto Post([FromBody]RoleFonctionnelDto roleFonctionnelDto)
        {
            if (ModelState.IsValid)
            {
                return this.service.Insert(roleFonctionnelDto);
            }

            return null;
        }

        // PUT: api/RoleFonctionnel/5
        public RoleFonctionnelDto Put([FromBody]RoleFonctionnelDto roleFonctionnelDto)
        {
            if (ModelState.IsValid)
            {
                return this.service.Update(roleFonctionnelDto);
            }

            return null;
        }

        // DELETE: api/RoleFonctionnel/5
        [Route("DeleteRoleFonctionnel/{id:int}", Name = "RoleFonctionnelDelete")]
        public void Delete(int id)
        {
            this.service.Delete(id);
        }

        [Route("DeleteRoleTechniqueFormFonctionnelRole/{roleTechniqueId:int}/{roleFonctionnelId:int}"
            , Name = "DeleteRoleTechniqueFormFonctionnelRole")]
        public void DeleteRoleTechniqueFormFonctionnelRole(int roleTechniqueId, int roleFonctionnelId)
        {
            this.service.DeleteRoleTechniqueFormFonctionnelRole(roleTechniqueId, roleFonctionnelId);
        }
    }
}
