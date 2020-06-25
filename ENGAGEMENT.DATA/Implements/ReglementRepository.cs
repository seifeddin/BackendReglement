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
    public class ReglementRepository : Repository<Reglement> , IReglementRepository
    {
        public ReglementRepository(REG_FSS_DB context) : base(context)
        {
        }

        public List<CanvasReglement> GetReglementPourSuivi()
        {
            List<CanvasReglement> resultat = new List<CanvasReglement>();
            IQueryable<Reglement> reglements = from reg in _context.Reglement
                join detReg in _context.DetailReglement on reg.Id equals detReg.IdReglement
                join modReg in _context.ModeReglement on detReg.IdModeReglement equals modReg.Id
                where modReg.Description == "CHEQUE"
                select reg;
            foreach (var item in reglements)
            {
                CanvasReglement canvasReglement = new CanvasReglement();
                canvasReglement.Id = item.Id;
                canvasReglement.IdBonAPayer = item.IdBonAPayer;
                canvasReglement.DateSignature = item.BonAPayer?.DateSignature;
                canvasReglement.DateValidation = item.DateValidation;
                canvasReglement.EcheanceReglement = item.Echeance;
                canvasReglement.ValiderPar = item.ValiderPar;
                canvasReglement.IdSuiviBancaire = item.IdSuiviBancaire;
                canvasReglement.EstImpaye = item.SuiviBancaire?.EstImpayes;
                canvasReglement.EstPreavis = item.SuiviBancaire?.EstPreavis;
                canvasReglement.EstRegle = item.SuiviBancaire?.EstRegle;
                canvasReglement.MontantRetenu = item.Retenu?.RubriqueRetenu.Sum(p => p.MontantTtc);
                canvasReglement.MontantTotalEcheance = item.DetailReglement
                    .Where(p => p.ModeReglement.Description == "CHEQUE").Sum(p => p.Montant);
                canvasReglement.NetAPayer = item.BonAPayer?.NetAPayer;
                canvasReglement.RaisonSocial =
                    item.ReglementFacture?.FirstOrDefault()?.Facture.Fournisseur.RaisonSocial ?? $"{item.ReglementFacture?.FirstOrDefault()?.Facture.Fournisseur.Nom} {item.ReglementFacture?.FirstOrDefault()?.Facture.Fournisseur.Prenom}";
                canvasReglement.NumFRs = item.ReglementFacture?.FirstOrDefault()?.Facture.Fournisseur.Id ?? 0;
                canvasReglement.IdBanque = item.DetailReglement.FirstOrDefault(p => p.ModeReglement.Description == "CHEQUE")?.IdBanque;
                resultat.Add(canvasReglement);
            }
            return resultat;
        }
    }
}
