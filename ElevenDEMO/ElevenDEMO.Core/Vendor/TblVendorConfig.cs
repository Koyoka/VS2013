using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenDEMO.Vendor
{
    public class TblVendorConfig : EntityTypeConfiguration<TblVendor>
    {
        public TblVendorConfig()
        {
            //this.HasKey(t => t.VendorCode);
            this.Ignore(x => x.Id);
        }
    }
}
