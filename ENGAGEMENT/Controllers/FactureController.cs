using ENGAGEMENT.CORE.Dto;
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
    [RoutePrefix("api/facture")]
    public class FactureController : ApiController
    {
        public readonly IFactureService factureService;
        public readonly IMapper mapper;

        public FactureController(IFactureService factureService, IMapper mapper)
        {
            this.factureService = factureService ?? throw  new ArgumentNullException(nameof(factureService));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        [HttpGet]
        [Route("factures/{id}", Name = "GetFacturesByFournisseur")]
        public List<FactureDto> GetFacturesByFournisseur(int id)
        {
           return this.factureService.GetFacturesByFournisseur(id).ToList();
        }
        // GET: api/facture
        public IEnumerable<FactureDto> Get()
        {
            return this.factureService.GetAll().Select(this.mapper.Map<FactureDto>);
        }

        // GET: api/facture/5
        public FactureDto Get(int id)
        {
            return this.mapper.Map<FactureDto>(this.factureService.GetById(id));
        }

        // POST: api/facture
        public FactureDto Post([FromBody]FactureDto factureDto)
        {
            if (ModelState.IsValid)
            {
                return this.factureService.Insert(factureDto);
            }

            return null;
        }

        // PUT: api/facture/5
        public FactureDto Put(int id, [FromBody]FactureDto factureDto)
        {
            if (ModelState.IsValid)
            {
                return this.factureService.Update(factureDto);
            }

            return null;
        }

        // DELETE: api/facture/5
        public void Delete(int id)
        {
            this.factureService.Delete(id);
        }
    }
}
