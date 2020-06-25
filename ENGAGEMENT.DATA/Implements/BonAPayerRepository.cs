using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENGAGEMENT.DATA.Interfaces;
using ENGAGEMENT.DATA.Model;
using ENGAGEMENT.ENTITY;

namespace ENGAGEMENT.DATA.Implements
{
    public class BonAPayerRepository : Repository<BonAPayer>, IBonAPayerRepository
    {
        private REG_FSS_DB context;
        public BonAPayerRepository(REG_FSS_DB context) : base(context)
        {
            this.context = context;
        }

        public List<ListBonAPayer> GetAllBonApayer()
        {
            var bonAPayer = from b in this.context.BonAPayer
                            join r in this.context.Reglement on b.Id equals r.IdBonAPayer
                            join fr in this.context.ReglementFacture on r.Id equals fr.IdReglement
                            join f in this.context.Facture on fr.IdFacture equals f.Id
                            join fo in this.context.Fournisseur on f.IdFournisseur equals fo.Id
                            select new ListBonAPayer
                            {
                                Id = b.Id,
                                MontantRetenu = b.MontantRetenu,
                                MontantTotalEcheance = b.MontantTotalEcheance,
                                NetAPayer = b.NetAPayer,
                                ValiderPar = b.ValiderPar,
                                DateValidation = b.DateValidation,
                                DateSignature = b.DateSignature,
                                EstRegle = b.EstRegle,
                                NumFRs = fo.Id,
                                RaisonSocial = fo.RaisonSocial,
                                NomPrenom = fo.Nom + " " + fo.Prenom,
                                EstValide = b.DateValidation != null ? true : false,
                                NumReglement = r.Id,
                                EcheanceReglement = r.Echeance

                            };
            return bonAPayer.Distinct().ToList();
        }


    }
}
