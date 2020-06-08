using ENGAGEMENT.CORE.Dto;
using ENGAGEMENT.SERVICES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ENGAGEMENT.Controllers
{
    [RoutePrefix("api/facture")]
    public class FactureController : ApiController
    {
        public IFactureService factureService;

        public FactureController(IFactureService factureService)
        {
            this.factureService = factureService;
        }
        [HttpGet]
        [Route("factures/{id}", Name = "GetFacturesByFournisseur")]
        public List<FactureDto> GetFacturesByFournisseur(int id)
        {
           return this.factureService.GetFacturesByFournisseur(id).ToList();
        }
        }
}
