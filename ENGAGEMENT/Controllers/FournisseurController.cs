using ENGAGEMENT.CORE.Dto;
using ENGAGEMENT.ENTITY;
using ENGAGEMENT.SERVICES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ENGAGEMENT.Controllers
{
    [RoutePrefix("api/Fournisseur")]
    public class FournisseurController : ApiController
    {
        public IFournisseurService service;
        public FournisseurController(IFournisseurService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("",Name = "GetAll")]
        public List<FournisseurDto> GetAll()
        {
           return service.GetAllFournisseurs().ToList();
            //return new REG_FSS_DB().Fournisseur.AsEnumerable().Select(p=> new Fournisseur {
            //    RaisonSocial = p.RaisonSocial,
            //    Nom = p.Nom
            //}).ToList();                
        }
    }
}
