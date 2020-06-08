using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENGAGEMENT.CORE.Dto
{
   public class FactureDto
    {
        public int Id { get; set; }
        public string Reference { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.DateTime> Echeance { get; set; }
        public Nullable<decimal> MontantTotale { get; set; }
        public Nullable<decimal> MontantDev { get; set; }
        public Nullable<decimal> MontantRegle { get; set; }
        public Nullable<decimal> MontantReste { get; set; }
        public string Statut { get; set; }
        public int IdFournisseur { get; set; }
    }
}
