using ENGAGEMENT.CORE.Dto;
using ENGAGEMENT.ENTITY;
using ENGAGEMENT.SERVICES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;

namespace ENGAGEMENT.Controllers
{
   [RoutePrefix("api/Fournisseur")]
    //[Route("api/Fournisseur")]
    public class FournisseurController : ApiController
    {
        public IFournisseurService service;
        public readonly IMapper mapper;
        public FournisseurController(IFournisseurService service, IMapper mapper)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        [Route("suppliers", Name = "GetAll")]
        public List<FournisseurDto> GetAll()
        {
           return service.GetAllFournisseurs().ToList();
            //return new REG_FSS_DB().Fournisseur.AsEnumerable().Select(p=> new Fournisseur {
            //    RaisonSocial = p.RaisonSocial,
            //    Nom = p.Nom
            //}).ToList();                
        }
        [HttpGet]
        [Route("GetLookupSuppliers", Name = "GetLookupFournisseur")]
        public List<LookupDto> GetLookupFournisseur()
        {
            return this.service.GetLookupFournisseurs();
        }
        // GET: api/Fournisseur
        [Route("GetAllFournisseurs", Name = "GetAllFournisseurs")]
        public IEnumerable<FournisseurDto> Get()
        {
            return this.service.GetAll().Select(this.mapper.Map<FournisseurDto>);
        }

        // GET: api/Fournisseur/5
        [Route("GetFournisseur", Name = "GetFournisseur")]
        public FournisseurDto Get(int id)
        {
            return this.mapper.Map<FournisseurDto>(this.service.GetById(id));
        }

        // POST: api/Fournisseur
        public FournisseurDto Post([FromBody]FournisseurDto fournisseurDto)
        {
            if (ModelState.IsValid)
            {
                return this.service.Insert(fournisseurDto);
            }

            return null;
        }

        // PUT: api/Fournisseur/5
        public FournisseurDto Put(int id, [FromBody]FournisseurDto fournisseurDto)
        {
            if (ModelState.IsValid)
            {
                return this.service.Update(fournisseurDto);
            }

            return null;
        }

        // DELETE: api/Fournisseur/5
        public void Delete(int id)
        {
            this.service.Delete(id);
        }
        [HttpGet]
        [Route("GetReglementDtosByFournissuer/{id}",Name = "GetReglementDtosByFournissuer")]
        public List<ReglementDto> GetReglementDtosByFournissuer(int id)
        {
            return this.service.ListReglementDtoByFournisseur(id);
        }
    }
}
