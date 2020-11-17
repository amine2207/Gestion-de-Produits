using GP.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Data.Configurations
{
    public class FactureConfiguration : EntityTypeConfiguration<Facture>
    {
        public FactureConfiguration()
        {
            HasKey(c => new
            {
                c.ClientFk,
                c.ProductFk,
                c.DateAchat
            });
            // 1..* entre Client et Facture
            HasRequired(f => f.Client)
.WithMany(c => c.Factures)
.HasForeignKey(f => f.ClientFk)
.WillCascadeOnDelete(false);
            // 1..* entre Product et Facture
            HasRequired(f =>f.Produit)
.WithMany(p => p.Factures)
.HasForeignKey(f => f.ProductFk)
.WillCascadeOnDelete(false);


        }
    }
}
