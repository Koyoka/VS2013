using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ElevenDEMO.Vendor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenDEMO.BizBaseData.Dtos
{
    [AutoMapFrom(typeof(TblVendor))]
    public class VendorDto : EntityDto//<string>
    {
        
        public  string VendorCode { get; set; }

        public  string Vendor { get; set; }

        public  string Address { get; set; }
    }
}
