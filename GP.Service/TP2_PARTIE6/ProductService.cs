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
        public void DeleteOldProducts()
        {
           var q =  GetMany(p => (DateTime.Now - p.DateProd).TotalDays > 365); 
           foreach (Product p in q)
            {
                Delete(p);
            }
        }

        public IEnumerable<Product> FindMost5ExpensiveProds()
        {
            /*var q = from p in GetMany()
                    orderby p.Price descending
                    select p;
            return q.Take(5);*/
            return GetMany().
                    OrderByDescending(p=>p.Price)
                       .Take(5);
            
        }

        public IEnumerable<Product> GetProdsByClient(Client c)
        {
            FactureService fs = new FactureService();
            /* var q = from p in GetMany()
                     where p.Factures == fs.GetProdsByClient(c)
                     select p;*/
            var q = fs.GetMany(f => f.ClientFk == c.CIN)
                        .Select(f => f.Produit);
            return q; 

        }

        public float UnavailableProductsPercentage()
        {
            float res = 0;
            /*var q_t = from p in GetMany()
                      select p;

            var q_p = from p in GetMany()
                    where p.Quantity == 0
                    select p ;
            res = q_p.Count() / q_t.Count() * 100 ;*/
            int q_t = GetMany().Count();
            int q_p = GetMany(p => p.Quantity == 0).Count();
            res = (q_p / q_t)  * 100; 
            return res;
        }



        
    }
}
