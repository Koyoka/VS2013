using Abp.EntityFramework;
using ElevenDEMO.Vendor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenDEMO.EntityFramework.Repositories
{
    public class TblVendorRepository : ElevenDEMORepositoryBase<TblVendor>,ITblVendorRepository
    {
        public TblVendorRepository(IDbContextProvider<ElevenDEMODbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
    }
}
