using Abp.Application.Services;
using ElevenDEMO.BizBaseData.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenDEMO.BizBaseData
{
    public interface IBizBaseDataAppService : IApplicationService
    {
        GetVendorsOutput GetVendors();

        VendorDto GetVendor(GetVendorInput input);
    }
}
