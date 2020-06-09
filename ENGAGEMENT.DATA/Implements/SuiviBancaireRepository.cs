﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENGAGEMENT.DATA.Interfaces;
using ENGAGEMENT.ENTITY;

namespace ENGAGEMENT.DATA.Implements
{
    public class SuiviBancaireRepository : Repository<SuiviBancaire>, ISuiviBancaireRepository
    {
        public SuiviBancaireRepository(REG_FSS_DB context) : base(context)
        {
        }
    }
}
