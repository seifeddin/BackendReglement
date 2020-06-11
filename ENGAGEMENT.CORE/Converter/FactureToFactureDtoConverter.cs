using AutoMapper;
using ENGAGEMENT.CORE.Dto;
using ENGAGEMENT.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENGAGEMENT.CORE.Converter
{
   public class FactureToFactureDtoConverter:ITypeConverter<Facture, FactureDto>
   {
       private readonly IMapper mapper;
        public FactureToFactureDtoConverter(IMapper mapper)
        {
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        
        public FactureDto Convert(Facture source, FactureDto destination, ResolutionContext context)
            {
                if(source==null)
                {
                    return null; // Best pratique converteur il ne faut pas levé une exception
                }

                destination = new FactureDto();
                destination.Id = source.Id;
                destination.Reference = source.Reference;
                destination.Date = source.Date;
                destination.Echeance = source.Echeance;
                destination.MontantTotale = source.MontantTotale;
                destination.MontantDev = source.MontantDev;
                destination.MontantRegle = source.MontantRegle;
                destination.MontantReste = source.MontantReste;
                destination.Statut = source.Statut;
                destination.IdFournisseur = source.IdFournisseur;
                destination.Fournisseur = this.mapper.Map<FournisseurDto>(source.Fournisseur);
                destination.ReglementFactures =
                    source.ReglementFacture.Select(this.mapper.Map<ReglementFactureDto>).ToList();
                return destination;
            }
        }
}
