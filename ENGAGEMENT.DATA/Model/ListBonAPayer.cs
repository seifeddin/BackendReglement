using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENGAGEMENT.DATA.Model
{
    public class ListBonAPayer
    {
        public int Id { get; set; }
        public Nullable<decimal> MontantRetenu { get; set; }
        public Nullable<decimal> MontantTotalEcheance { get; set; }
        public Nullable<decimal> NetAPayer { get; set; }
        public string ValiderPar { get; set; }
        public Nullable<System.DateTime> DateValidation { get; set; }
        public Nullable<System.DateTime> DateSignature { get; set; }
        public Nullable<bool> EstRegle { get; set; }
        public int NumFRs { get; set; }
        public string RaisonSocial { get; set; }
        public string NomPrenom { get; set; }
        public bool EstValide { get; set; }

        public int NumReglement { get; set; }
        public DateTime? EcheanceReglement{get;set;}

    }
}
