using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENGAGEMENT.CORE.Dto
{
    public class UtilisateurDto
    {
        public int Id { get; set; }
        public Nullable<int> IdRoleFonctionnel { get; set; }
        public string NomUtilisateur { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string MotDePasse { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public bool? EstActive { get; set; }

        public RoleFonctionnelDto RoleFonctionnel { get; set; }
    }
}
