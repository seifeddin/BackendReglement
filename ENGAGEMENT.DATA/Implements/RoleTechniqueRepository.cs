using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using ENGAGEMENT.DATA.Interfaces;
using ENGAGEMENT.ENTITY;

namespace ENGAGEMENT.DATA.Implements
{
    public class RoleTechniqueRepository : Repository<RoleTechnique>, IRoleTechniqueRepository
    {
        public RoleTechniqueRepository(REG_FSS_DB context) : base(context)
        {
        }

        public List<RoleTechnique> GetNotAffectedRoleTechnique(int idRoleFonctionnel)
        {
            IQueryable<int> focTechRoles = from roletech in _context.FoncTechRole
                where roletech.IdFoncRole == idRoleFonctionnel select roletech.IdTechRole;

            IQueryable<RoleTechnique> roleTechniques = from tech in _context.RoleTechnique
                where !focTechRoles.Contains(tech.Id) select tech ;

            return roleTechniques.ToList();
        }
    }
}
