using GP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Service.TP2_PARTIE6
{
    public interface IFactureService
    {
        IEnumerable<Facture> GetProdsByClient(Client c);
    }
}
