using ENGAGEMENT.DATA.Interfaces;
using ENGAGEMENT.ENTITY;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ENGAGEMENT.DATA.Implements
{
    public class FournisseursRepository : Repository<Fournisseur>, IFournisseursRepository
    {
        private readonly REG_FSS_DB context;
        public FournisseursRepository(REG_FSS_DB context):base(context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public List<Reglement> ListReglementByFournisseur(int id)
        {
            List<Reglement> reglement = (from furr in this.context.Fournisseur
                where furr.Id == id
                join fac in this.context.Facture on furr.Id equals fac.IdFournisseur
                join regdet in this.context.ReglementFacture on fac.Id equals regdet.IdFacture
                join reg in this.context.Reglement on regdet.IdReglement equals reg.Id
                select  reg).ToList();

            return reglement;
        }
    }
}
