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
    public class FournisseurToFournisseurDtoConverter : ITypeConverter<Fournisseur, FournisseurDto>
    {
        public FournisseurDto Convert(Fournisseur source, FournisseurDto destination, ResolutionContext context)
        {
            if(source==null)
            {
                throw new NullReferenceException(nameof(source));
            }
            destination = new FournisseurDto();
            destination.Id = source.Id;
            destination.Nom = source.Nom;
            destination.Prenom = source.Prenom;
            destination.RaisonSocial = source.RaisonSocial;
            destination.Solde = source.Solde;
            destination.FraisGeneraux = source.FraisGeneraux;
            destination.EstMorale = source.EstMorale;
            destination.EstPhysique = source.EstPhysique;


            return destination;
            
        }
    }
}
