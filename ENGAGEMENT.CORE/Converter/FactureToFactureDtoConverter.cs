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
        
public FactureDto Convert(Facture source, FactureDto destination, ResolutionContext context)
        {
            if(source==null)
            {
                throw new ArgumentNullException(nameof(source));
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
            return destination;
        }
    }
}
