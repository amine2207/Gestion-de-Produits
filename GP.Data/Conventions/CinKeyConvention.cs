using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Data.Conventions
{
  public class CinKeyConvention : Convention
    {
        public CinKeyConvention()
        {

            this.Properties().Where(i => i.Name.Equals("CIN")).Configure(k => k.IsKey());
        }
    }
}
