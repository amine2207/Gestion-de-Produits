using GP.Domain;
using ServicesPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Service.TP2_PARTIE6
{
    public class ProductService : Service<Product>, IProductService
    {
        public IEnumerable<Product> FindMost5ExpensiveProds()
        {
            throw new NotImplementedException();
        }
    }
}
