﻿using ENGAGEMENT.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENGAGEMENT.DATA.Interfaces
{
    public interface IFournisseursRepository:IRepository<Fournisseur>
    {
        List<Reglement> ListReglementByFournisseur(int id);
    }
}
