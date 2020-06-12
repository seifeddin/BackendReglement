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
    [RoutePrefix("api/Rubrique")]
    public class RubriqueController : ApiController
    {
        private readonly IRubriqueService service;
        private readonly IMapper mapper;
        public RubriqueController(IRubriqueService service, IMapper mapper)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        // GET: api/Rubrique
        public IEnumerable<RubriqueDto> Get()
        {
            return this.service.GetAll().Select(this.mapper.Map<RubriqueDto>);
        }

        // GET: api/Rubrique/5
        public RubriqueDto Get(int id)
        {
            return this.mapper.Map<RubriqueDto>(this.service.GetById(id));
        }

        // POST: api/Rubrique
        public RubriqueDto Post([FromBody]RubriqueDto rubriqueDto)
        {
            if (ModelState.IsValid)
            {
                return this.service.Insert(rubriqueDto);
            }

            return null;
        }

        // PUT: api/Rubrique/5
        public RubriqueDto Put(int id, [FromBody]RubriqueDto rubriqueDto)
        {
            if (ModelState.IsValid)
            {
                return this.service.Update(rubriqueDto);
            }

            return null;
        }

        // DELETE: api/Rubrique/5
        public void Delete(int id)
        {
            this.service.Delete(id);
        }
    }
}
