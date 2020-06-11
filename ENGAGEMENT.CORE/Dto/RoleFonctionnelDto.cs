using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENGAGEMENT.CORE.Dto
{
    public class RoleFonctionnelDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public List<UtilisateurDto> Utilisateur { get; set; }
        public List<FoncTechRoleDto> FoncTechRole { get; set; }
    }
}
