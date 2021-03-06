﻿using GP.Domain;
using ServicesPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Service.TP2_PARTIE6
{
    public class FactureService : Service<Facture>, IFactureService
    {
        public IEnumerable<Facture> GetProdsByClient(Client c)
        {
            var q = from f in GetMany()
                    where f.ClientFk == c.CIN
                    select f;
            return q;                  
        }
    }
}
