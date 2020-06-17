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
    [RoutePrefix("api/Utilisateur")]
    public class UtilisateurController : ApiController
    {
        private readonly IUtilisateurService service;
        private readonly IMapper mapper;

        public UtilisateurController(IUtilisateurService service, IMapper mapper)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        // GET: api/Utilisateur
        [HttpGet]
        [Route("GetUtilisateurs/", Name = "GetAllUsers")]
        public List<UtilisateurDto> GetUtilisateurs()
        {
            return this.service.GetAll().Select(this.mapper.Map<UtilisateurDto>).ToList();
        }

        // GET: api/Utilisateur/5
        [HttpGet]
        [Route("GetUtilisateurById/{id}",Name = "GetUtilisateurById")]
        public UtilisateurDto Get(int id)
        {
            return this.mapper.Map<UtilisateurDto>(this.service.GetById(id));
        }

        [HttpGet]
        [Route("GetLookup", Name = "GetLookupUtilisateur")]
        public List<LookupDto> GetLookup()
        {
            return this.service.GetLookupDto();
        }

        // POST: api/Utilisateur
        public UtilisateurDto Post([FromBody]UtilisateurDto utilisateurDto)
        {
            if (ModelState.IsValid)
            {
                return this.service.Insert(utilisateurDto);
            }

            return null;
        }

        // PUT: api/Utilisateur/5
        public UtilisateurDto Put([FromBody]UtilisateurDto utilisateurDto)
        {
            if (ModelState.IsValid)
            {
                return this.service.Update(utilisateurDto);
            }

            return null;
        }

        // DELETE: api/Utilisateur/5
        [HttpDelete]
        [Route("Delete/{id:int}",Name = "DeleteUtilisateur")]
        public bool Delete(int id)
        {
            this.service.Delete(id);
            return true;
        }
    }
}
